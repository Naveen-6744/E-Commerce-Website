 document.addEventListener("DOMContentLoaded", () => {
    const openButton = document.querySelector(".ham");
    const closeButton = document.querySelector(".close");
    const menu = document.querySelector(".menu");
    const navLinks = document.querySelectorAll(".menu ul li a"); // Added this line to select all menu links

    openButton.addEventListener("click", () => {
        menu.classList.add("visible");
    });

    closeButton.addEventListener("click", () => {
        menu.classList.remove("visible");
    });

    // Add event listeners to each navigation link to close the menu when clicked
    navLinks.forEach((link) => {
        link.addEventListener("click", () => {
            menu.classList.remove("visible");
        });
    });
});
