**Image Slider**

This repository contains a simple, responsive image slider built with HTML, CSS, and JavaScript. The slider automatically cycles through images and allows manual navigation through "previous" and "next" buttons.

Features

    Automatic image sliding with a fade effect
    Manual navigation through previous and next buttons
    Responsive design

Functions Explanation

**1) initializer() function :**

This function initializes the slider. It checks if there are any slides, 
adds the showimg class to the first slide to display it,
and sets an interval to automatically move to the next slide every 3 seconds.

**2) showslide(index)**

This function shows a specific slide based on the provided index. 
It ensures the slideIndex is within the bounds of the slides array, removes the showimg class from all slides,
and adds the showimg class to the current slide to display it

**3)prevslide()**

This function shows the previous slide. It clears the existing interval to stop the automatic sliding, 
decrements the slideIndex, calls showslide to display the previous slide.

**4)nextslide()**

This function shows the next slide. It clears the existing interval to stop the automatic sliding,
increments the slideIndex, calls showslide to display the next slide.


