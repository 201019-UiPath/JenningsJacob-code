function GetPokemon()
{
    let xhr = new XMLHttpRequest();
    let pokemon = {};
    let pokemonInput = document.querySelector('#pokemonInput').value;

    // the ready state of the xhttp object determines the state of the reques:
    // 0 - uninitialized
    // 1 - loading (server connection established) the open method has been invoked
    // 2 - loaded (request received by server) send has been called
    // 3 - interactive (processing request) response body is being received
    // 4 - complete (response received)
    // the status code checks if the operation was successful
    xhr.onreadystatechange = function(){
        if(this.readyState == 4 && this.status == 200)
        {
            // JSON.parse is a function that converts the response body to a JS object
            pokemon = JSON.parse(xhr.responseText);
            document.querySelector('.pokemon-result img').setAttribute('src', pokemon.sprites.front_default);
            document.querySelectorAll('.pokemon-result caption').forEach((element) => element.remove());
            let caption = document.createElement('caption');
            let pokeName = document.createTextNode(pokemon.forms[0].name);
            caption.appendChild(pokeName);
            document.querySelector('.pokemon-result').appendChild(caption);
            document.querySelector('#pokemonInput').value = '';
        }
    }
    xhr.open('GET', `https://pokeapi.co/api/v2/pokemon/${pokemonInput}`, true);
    xhr.send()
}

function GetDigimon()
{
    let digiName = document.querySelector('#digimonInput').value;
    fetch(`https://digimon-api.vercel.app/api/digimon/name/${digiName}`)
    .then(response => response.json())
    .then(result => {
        document.querySelector('.digimon-result img').setAttribute('src', result[0].img);
        document.querySelectorAll('.digimon-result caption').forEach((element) => element.remove());
        let caption = document.createElement('caption');
        caption.appendChild(document.createTextNode(result[0].name));
        document.querySelector('.digimon-result').appendChild(caption);
        document.querySelector('#digimonInput').value = '';
    })
}