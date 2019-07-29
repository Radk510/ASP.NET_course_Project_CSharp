const openListBtnClubs = document.getElementsByClassName("openListBtnClubs");
const infoContainerClubs = document.getElementsByClassName("infoContainerClubs");



for (let i = 0; i < openListBtnClubs.length; i++) {
    openListBtnClubs[i].addEventListener("click", function () {
        infoContainerClubs[i].classList.toggle("openSection");
    })
}


