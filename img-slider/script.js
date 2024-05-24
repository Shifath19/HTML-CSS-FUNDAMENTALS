const slides = document.querySelectorAll(".slides img");

let slideIndex = 0;
let intervalId = null;

//initializer();

document.addEventListener("DOMContentLoaded",initializer);


function initializer(){

  if(slides.length > 0){
    slides[slideIndex].classList.add("showimg");
    intervalId = setInterval(nextslide,3000)
  }
}

function showslide(index){

  if(index >= slides.length){
    slideIndex = 0;
  }
  else if(index <0){
    slideIndex = slides.length - 1;
  }

  slides.forEach(slide =>{
    slide.classList.remove("showimg")
  });

  slides[slideIndex].classList.add("showimg")

}

function prevslide(){
  clearInterval(intervalId);
  slideIndex--;
  showslide(slideIndex);

}

function nextslide(){
  clearInterval(intervalId);
  slideIndex++;
  showslide(slideIndex);
}
