// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*Loader*/
$(window).on("load", function () {
    $(".loader-wrapper").fadeOut(1000); // You can adjust the fadeOut duration
});

function myFunction() {
    var element = document.body;
    element.classList.toggle("dark-mode");
}

function isMobileDevice() {
    return (typeof window.orientation !== "undefined") || (navigator.userAgent.indexOf('IEMobile') !== -1);
}

if (isMobileDevice()) {
    var darkModeButton = document.getElementById("dark-mode-button");
    if (darkModeButton) {
        darkModeButton.addEventListener("click", myFunction);
    }
}