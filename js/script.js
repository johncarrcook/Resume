document.addEventListener("DOMContentLoaded", function (event) {
    function Shade(event) {
        this.style.backgroundColor = "#D3D3D3";
    };

    var mainBoxes = document.getElementsByClassName("main-body-box");
    for (var i = 0; i < mainBoxes.length; i++) {
        mainBoxes[i].addEventListener("mousemove", Shade);
    };
});