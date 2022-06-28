let left = document.querySelectorAll(".fa-chevron-left");
let right = document.querySelectorAll(".fa-chevron-right");
let sliderItem = document.querySelector(".slider");

left.forEach(leftBtn => {
    leftBtn.addEventListener("click", function (e) {
        e.preventDefault();
        let active = document.querySelector(".active");

        active.classList.remove("active");
        if(active.previousElementSibling == null){
            sliderItem.lastElementChild.classList.add("active");
        }
        else{
            active.previousElementSibling.classList.add("active");
        }
    })
})

right.forEach(rBtn => {
    rBtn.addEventListener("click", function (e) {
        e.preventDefault();
        let active = document.querySelector(".active");
        active.classList.remove("active");
        console.log("click");

        if(active.nextElementSibling == null){
            sliderItem.firstElementChild.classList.add("active");
        }
        else{
            active.nextElementSibling.classList.add("active");
        }
    })
})