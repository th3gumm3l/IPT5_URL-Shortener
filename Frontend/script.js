//get element
let shortLink = document.getElementById("short-url");

// sets post Url to Localhost
const postUrl = "https://localhost:7230/Url";

// Get the button by id
var input = document.getElementById("url-input");

// Main function
async function submitLink() {
    try {
        var input = document.getElementById("url-input").value; //gets value of url-input
        var isInvalidUrl = !isUrl(input); //checks input

        //Wenn die URL falsch ist, wird es nicht ausgeführt
        if (isInvalidUrl) {
            alert("URL not correct --> You need https://");
            
        }

        else{
            var url = postUrl + `?originalUrl=${input}` //puts the input into the new string
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
    } 
    catch (error) {
        console.log(error);
    }
}

//überprüft ob der Link korrekt ist
function isUrl(url) {
    return /^https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,24}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)+$/.test(url);
  }


// Execute a function when the user presses a key on the keyboard
input.addEventListener("keypress", function(event) {
  // If the user presses the "Enter" key on the keyboard
  if (event.key === "Enter") {
    // Cancel the default action, if needed
    event.preventDefault();
    // Trigger the button element with a click
    document.getElementById("buttonSubmit").click();
  }
});