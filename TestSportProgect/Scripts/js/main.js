const buttons = document.getElementsByClassName('openListBtn');
const infoContainer = document.getElementsByClassName('infoContainer');
const apiContent = document.getElementsByClassName("apiContent");
const prevBtn = document.getElementsByClassName("prevBtn");
const nxtBtn = document.getElementsByClassName("nxtBtn");
let counter = 0;
let apiPathAdresses = [
    {
        "nameOfContent": "Latest friendly matches",
        "apiPath": "https://www.scorebat.com/video-api/v1/",
        "insertHtmlData": function htmlData(infoFromApiJSON) {
            return `
                            <div class="d-flex jumbotron">
                                <div>
                                    <h5 class="desc">Football match between:</h5> 
                                    <h2>${infoFromApiJSON[counter].title}</h2>
                                    <h5 class="desc">Competition:</h5>
                                    <h2>${infoFromApiJSON[counter].competition.name}</h2>                                    
                                </div>                                
                                <p>${infoFromApiJSON[counter].embed}</p>
                            
                            </div>
                            `
        },

    },
    {
        "nameOfContent": "Latest england football news",
        "apiPath": "https://newsapi.org/v2/top-headlines?country=gb&category=sports&apiKey=d659da86d63041fb9607b518585d5058",
        "insertHtmlData": function htmlData(infoFromApiJSON) {
            return `        
                            <div class="jumbotron">
                                <h5>Today news:</h5> 
                                <h3>${infoFromApiJSON.articles[counter].title}</h3>
                                <p>${infoFromApiJSON.articles[counter].content}</p>
                                <img class="img-fluid" src="${infoFromApiJSON.articles[counter].urlToImage}" alt="news image">
                                <h5><a href="${infoFromApiJSON.articles[counter].url}">Go to ${infoFromApiJSON.articles[counter].source.name}...</a> </h5>
                                <p>${infoFromApiJSON.articles[counter].publishedAt}</p>

                            </div>
                            `
        }
    }
]

for (let i = 0; i < buttons.length; i++) {

    buttons[i].addEventListener('click', scoreFunction);

    function scoreFunction() {
        infoContainer[i].classList.toggle("d-none");
        let jsonRequest = new XMLHttpRequest();
        jsonRequest.open('GET', apiPathAdresses[i].apiPath);
        jsonRequest.onload = function () {

            if (counter == 0) {
                prevBtn[i].classList.add("d-none");
            }
            let parseInfoFromApi = JSON.parse(jsonRequest.responseText);
            apiContent[i].innerHTML = apiPathAdresses[i].insertHtmlData(parseInfoFromApi);

            //Next info button FUNCTION
            function NextBtnFunction(next, prev) {
                next.addEventListener('click', function () {
                    counter++;
                    if (counter > 0) {
                        prev.classList.remove("d-none");
                    } else {
                        prev.classList.add("d-none");
                    }
                    if (counter > parseInfoFromApi.length - 1) {
                        next.classList.add("d-none");
                    } else {
                        next.classList.remove("d-none");
                    }

                    apiContent[i].innerHTML = apiPathAdresses[i].insertHtmlData(parseInfoFromApi);
                });
            }
            NextBtnFunction(nxtBtn[i], prevBtn[i]);

            //Previous info Button FUNCTION
            function previousBtnFunction(prev, next) {
                prev.addEventListener('click', function () {
                    counter--;
                    if (counter > 0) {
                        prev.classList.remove("d-none");
                    } else {
                        prev.classList.add("d-none");
                    }
                    if (counter > parseInfoFromApi.length - 1) {
                        next.classList.add("d-none");
                    } else {
                        next.classList.remove("d-none");
                    }

                    apiContent[i].innerHTML = apiPathAdresses[i].insertHtmlData(parseInfoFromApi);
                });
            }
            previousBtnFunction(prevBtn[i], nxtBtn[i]);
        }
        jsonRequest.send();


    }

}





