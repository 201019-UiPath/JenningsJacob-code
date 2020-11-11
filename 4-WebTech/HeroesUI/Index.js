function GetAllHeroes()
{
    const url = 'https://localhost:44380/SuperHero/get';
    fetch(url)
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#heroes tbody tr').forEach((element) => element.remove());
        let table = document.querySelector('#heroes tbody');
        for(let i = 0; i < result.length; i++)
        {
            let row = table.insertRow(table.rows.length);
            let rnCell = row.insertCell(0);
            rnCell.innerHTML = result[i].realName;

            let aCell = row.insertCell(1);
            aCell.innerHTML = result[i].alias;

            let hoCell = row.insertCell(2);
            hoCell.innerHTML = result[i].hideOut;
        }
    });
}

function AddAHero()
{
    let hero = {};
    hero.realName = document.querySelector('#realName').value;
    hero.alias = document.querySelector('#alias').value;
    hero.hideOut = document.querySelector('#hideOut').value;

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function(){
        if(this.readyState == 4 && this.status > 199 && this.status < 300)
        {
            alert('New hero added!');
            console.log(hero);
            document.querySelector('#realName').value = '';
            document.querySelector('#alias').value = '';
            document.querySelector('#hideOut').value = '';
            GetAllHeroes();
        }
    };
    xhr.open('POST', 'https://localhost:44380/SuperHero/add', true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(hero));
}