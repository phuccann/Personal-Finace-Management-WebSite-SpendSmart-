function openBox(id) {
    var box = document.getElementById(id);
    if (box) {
        var currentStyle = window.getComputedStyle(box).display;
        box.style.display = (currentStyle === "none") ? "block" : "none";
    }
}