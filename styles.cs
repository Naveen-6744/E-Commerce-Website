 * {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/* Header styles */
header {
    display: flex;
    justify-content: space-evenly;
    align-items: center;
    height: 60px;
    width: 100%;
    background: black;
}

/* Navigation links in the header */
.heading ul {
    list-style: none;
    display: flex; /* Arrange items in a horizontal line */
    align-items: center; /* Vertically center align items */
}

.heading ul li {
    margin: 0 10px; /* Add some margin between the navigation items */
}

.heading ul li a {
    text-decoration: none;
    color: black;
    font-weight: 500;
    position: relative;
    color: white;
    font-size: 18px;
    transition-duration: 1s;
}

.heading ul li a:active {
    color: red;
}

.heading ul li a:hover {
    color: rgb(243, 168, 7);
    transition-duration: 1s;
}

.heading ul li a::before {
    content: '';
    height: 2px;
    width: 0px;
    position: absolute;
    left: 0;
    bottom: 0;
    background-color: white;
    transition-duration: 1s;
}

.heading ul li a:hover::before {
    width: 100%;
    transition-duration: 1s;
    background-color: rgb(243, 168, 7);
}

/* Search bar styles */
#input {
    height: 30px;
    width: 300px;
    text-decoration: none;
    border: 0px;
    padding: 5px;
}
 .logo a {
    color: white;
    font-size: 35px;
    font-weight: 500;
    text-decoration: none;
}

/* Icon styles */
ion-icon {
    width: 30px;
    height: 30px;
    background-color: white;
    color: black;
}

ion-icon:hover {
    cursor: pointer;
}

/* Search icon styles */
header a ion-icon {
    position: relative;
    right: 3px;
}

/* Image slider styles */
.img-slider img {
    max-width: 100%; /* Ensure images don't exceed the screen width */
    max-height: 100vh;
    object-fit: cover;
}
@keyframes slide {
    0% {
        left: 0px;
    }
    15% {
        left: 0px;
    }
    20% {
        left: -1080px;
    }
    32% {
        left: -1080px;
    }
    35% {
        left: -2160px;
    }
    47% {
        left: -2160px;
    }
    50% {
        left: -3240px;
    }
    63% {
        left: -3240px;
    }
    66% {
        left: -4320px;
    }
    79% {
        left: -4320px;
    }
    82% {
        left: -5400px;
    }
    100% {
        left: 0px;
    }
}

 .img-slider {
    display: flex;
    float: left;
    position: relative;
    width: 100%; /* Updated to 100% */
    height: auto; /* Adjust the height as needed */
    animation-name: slide;
    animation-duration: 10s;
    animation-iteration-count: infinite;
    transition-duration: 2s;
}

.heading1 {
    opacity: 0;
}

.search {
    display: flex;
    position: relative;
}

.section1 {
    width: 1080px;
    overflow: hidden;
    justify-content: center;
    align-items: center;
    margin: 0px auto;
}

.section2 .container {
    display: flex;
    width: 100%;
    height: max-content;
    flex-wrap: wrap;
    justify-content: center;
    margin: 10px auto;
}

.section2 .container .items {
    margin: 10px;
    width: 200px;
    height: 300px;
    background-color: white;
    border: 2.5px solid black;
    border-radius: 12px;
}

.section2 .container .items .name {
    text-align: center;
    background-color: rgb(240, 197, 6);
    height: 25px;
    padding-top: 4px;
    color: white;
    margin: 0;
}

.section2 .container .items .price {
    float: left;
    padding-left: 10px;
    display: block;
    width: 100%;
    color: rgb(255, 0, 0);
    font-weight: 650;
}

.section2 .container .items .info {
    padding-left: 10px;
    color: rgb(243, 168, 7);
}

.section2 .container .items .img img {
    width: 200px;
    height: 200px;
    margin: 0;
    padding: 0;
    border-radius: 12px;
    transition-duration: 0.8s;
}

.section2 .container .items .img {
    overflow: hidden;
    margin: 0;
}

.section2 .container .items:hover .img img {
    transform: scale(1.2);
    transition-duration: 0.8s;
    border-radius: 12px;
}

footer {
    display: flex;
    flex-direction: column;
    background-color: black;
    align-items: center;
    color: white;
}

.footer1 {
    display: flex;
    flex-direction: column;
    align-items: center;
    color: white;
    margin-top: 15px;
}

.social-media {
    display: flex;
    justify-content: center;
    color: white;
    flex-wrap: wrap;
}

.social-media a {
    color: white;
    margin: 20px;
    border-radius: 5px;
    margin-top: 10px;
    color: white;
}

.social-media a ion-icon {
    color: white;
    background-color: black;
}

.social-media a:hover ion-icon {
    color: red;
    transform: translateY(5px);
}

.footer2 {
    display: flex;
    width: 100%;
    justify-content: space-evenly;
    align-items: center;
    text-decoration: none;
    flex-wrap: wrap;
}

.footer0 {
    font-weight: 1200;
    transition-duration: 1s;
}

.footer0:hover {
    color: rgb(243, 168, 7);
}

.footer2 .heading {
    font-weight: 900;
    font-size: 18px;
}

.footer3 {
    margin-top: 60px;
    margin-bottom: 20px;
    display: flex;
    flex-wrap: wrap;
    justify-content: center;
}

.footer2 .heading:hover {
    color: rgb(243, 168, 7);
}

.footer2 .div:hover {
    transform: scale(1.05);
}

.footer3 h4 {
    margin: 0 10px;
}

.footer2 div {
    margin: 10px;
}

.menu {
    visibility: hidden;
    opacity: 0;
    position: absolute;
    top: 60px;
    width: 100%;
    background: black;
    text-align: center;
    z-index: 1;
    transition-duration: 0.5s;
}

.menu.visible {
    visibility: visible;
    opacity: 1;
}

.menu ul {
    padding: 20px;
}

.menu ul li {
    list-style: none;
    margin-bottom: 20px;
}

.menu ul li a {
    text-decoration: none;
    color: white;
    font-size: 24px;
    font-weight: 600;
    transition-duration: 0.5s;
}

.menu ul li a:hover {
    color: rgb(243, 168, 7);
}
