*{
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

.slider{
  position: relative;
  text-align: center;
  margin: auto;
  overflow: hidden;
  width: 80%;
  height: 90vh;
  margin-top: 40px;
}

.slides{
  position: relative;

}

.slides img{
  height: 100%;
  width: 100%;
  object-fit:cover;
  display: none;

}

.slider button{
  font-size: 2rem;
  padding: 10px 15px;
  position: absolute;
  top: 50%;
  transform: translatey(-50%);
  background-color: rgba(0, 0, 0, 0.507);
  color: white;
  border: none;
  cursor: pointer;
}

.next{
  right: 0;
}

.prev{
  left: 0;
}

img.showimg{
  display: block;
  animation-name: fade;
  animation-duration: 2s;
}

@keyframes fade{
  from{opacity: .5}
  to{opacity: 1}
}
