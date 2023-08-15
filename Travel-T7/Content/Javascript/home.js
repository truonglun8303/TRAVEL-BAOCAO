const page2 = [...document.querySelectorAll('.page-2-img')];
const leftbtn = [...document.querySelectorAll('.left')];
const rightbtn = [...document.querySelectorAll('.right')];

page2.forEach((item,i) => {
    let containerDimensions = item.getBoundingClientRect();
    let containerWidth = containerDimensions.width;
    leftbtn[i].addEventListener('click',() =>{
        item.scrollLeft -= containerWidth;
    })     
    rightbtn[i].addEventListener('click',() =>{
            item.scrollLeft += containerWidth;
    })
});

// var triangle = document.getElementById("triangle");
// var length = triangle.getTotalLength();

// // The start position of the drawing
// triangle.style.strokeDasharray = length;

// // Hide the triangle by offsetting dash. Remove this line to show the triangle before scroll draw
// triangle.style.strokeDashoffset = length;

// // Find scroll percentage on scroll (using cross-browser properties), and offset dash same amount as percentage scrolled
// window.addEventListener("scroll", myFunction);

// function myFunction() {
// var scrollpercent = (document.body.scrollTop + document.documentElement.scrollTop) / (document.documentElement.scrollHeight - document.documentElement.clientHeight);

//   var draw = length * scrollpercent;
  
//   // Reverse the drawing (when scrolling upwards)
//   triangle.style.strokeDashoffset = length - draw;
// };

const formuser = document.querySelector('.form-user');
const togget_menu = document.querySelector('.user');
const close = document.querySelector('.close');


togget_menu.onclick = function(){
  formuser.classList.toggle('hide');
}
close.onclick = function(){
  formuser.classList.remove('hide');
};

const cursor = document.querySelector('.cursor');
        document.addEventListener('mousemove', e=> {
            cursor.setAttribute("style", "top:" + (e.pageY - 20) +"px; left: " + (e.pageX - 20) + "px;")
        })

        var lastScroll = 0;
        menu = document.getElementById("menu");
        window.addEventListener("scroll", function () {
          var scrollTop =
            window.pageYOffset || document.documentElement.scrollTop;
          if (scrollTop > lastScroll) {
            menu.style.top = "-100px";
          } else {
            menu.style.top = "0";
          }
          lastScroll = scrollTop;
        });

        $(document).ready(function () {
          // $(window).scroll(function () {
          //   if ($(this).scrollTop()) {
          //     $(".menu").addClass("sticky");
          //   } else {
          //     $(".menu").removeClass("sticky");
          //   }
          // });
          $(window).scroll(function () {
            if ($(this).scrollTop()) {
              $("#img-home-2").addClass("active");
            } else {
              $("#img-home-2").removeClass("active");
            }
          });
          $(window).scroll(function () {
            if ($(this).scrollTop()) {
              $(".receive").addClass("active-1");
            } else {
              $(".receive").removeClass("active-1");
            }
          });
          $(window).scroll(function () {
            if ($(this).scrollTop()) {
              $(".supper-menu").removeClass("active-2");
            } else {
              $(".supper-menu").addClass("active-2");
            }
          });
        });

/***** START Container-3-slider *****/
document.getElementById('prev').onclick = function(){
    let lists = document.querySelectorAll('.item');
    document.getElementById('container-3-slider').append(lists[0]);

}
document.getElementById('next').onclick = function(){
  let lists = document.querySelectorAll('.item');
  document.getElementById('container-3-slider').prepend(lists[lists.length-1]);
}
/***** END Container-3-slider *****/
