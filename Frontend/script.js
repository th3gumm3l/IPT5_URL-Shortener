let shortLink = document.getElementById("short-url");

const postUrl = "https://localhost:7230/Url";


async function submitLink() {
    var input = document.getElementById("url-input").value;
    console.log(input);
    var url = postUrl + `?originalUrl=${input}`
    console.log(url);
    var response = await fetch(url, {
        headers: {
            'Accept': 'application/json'
        },
        method: "POST"
    }).then(response => response.json());

    shortLink.href = "https://localhost:7230/Url?id=" + response;
    shortLink.innerHTML = "https://localhost:7230/Url?id=" + response;
    shortLink.style.visibility = "visible";
}