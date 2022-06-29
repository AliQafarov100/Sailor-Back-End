let left = document.querySelectorAll(".fa-chevron-left");
let right = document.querySelectorAll(".fa-chevron-right");
let sliderItem = document.querySelector(".slider");

left.forEach(leftBtn => {
    leftBtn.addEventListener("click", function (e) {
        e.preventDefault();
        let active = document.querySelector(".activeSlider");


        active.classList.remove("activeSlider");
        if (active.previousElementSibling == null) {
            sliderItem.lastElementChild.classList.add("activeSlider");
        }
        else {
            active.previousElementSibling.classList.add("activeSlider");
        }
    })
})

right.forEach(rBtn => {
    rBtn.addEventListener("click", function () {

        let active = document.querySelector(".activeSlider");
        active.classList.remove("activeSlider");
        // console.log(active.nextElementSibling)

        if (active.nextElementSibling === null) {
            sliderItem.firstElementChild.classList.add("activeSlider");
            console.log("first")
        }
        else {
            active.nextElementSibling.classList.add("activeSlider");
            console.log("next")
        }
    })
})