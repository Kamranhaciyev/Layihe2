jQuery(function ($) {
  "use strict";

  let preloader = $(".preloader");

  setTimeout(function () {
    preloader.addClass("ready");
  }, preloader.data("timeout"));
});

// $('.owl-carousel').owlCarousel({
//     loop:true,
//     margin:30,
//     responsive:{
//         0:{
//             items:1
//         },
//         600:{
//             items:3
//         },
//     }
// });

// $(window).load(function() {
// 	$(".loader").delay(2000).fadeOut("slow");
//   $("#overlayer").delay(2000).fadeOut("slow");
// })

jQuery(function ($) {
  setTimeout(function () {
    $(".no-slider .left").addClass("init");
    $(".no-slider .right").addClass("init");
  }, 1200);

  var animation = function (slider) {
    let image = $(slider + " .swiper-slide-active img");
    let title = $(slider + " .title");
    let description = $(slider + " .description");
    let btn = $(slider + " .buttons");
    let nav = $(slider + " nav");

    image.toggleClass("aos-animate");
    title.toggleClass("aos-animate");
    description.toggleClass("aos-animate");
    btn.toggleClass("aos-animate");
    nav.toggleClass("aos-animate");

    setTimeout(function () {
      image.toggleClass("aos-animate");
      title.toggleClass("aos-animate");
      description.toggleClass("aos-animate");
      btn.toggleClass("aos-animate");
      nav.toggleClass("aos-animate");

      AOS.refresh();
    }, 100);

    if ($(".full-slider").hasClass("animation")) {
      $(".full-slider .left").addClass("off");
      $(".full-slider .left").removeClass("init");
      $(".full-slider .right").addClass("off");
      $(".full-slider .right").removeClass("init");

      setTimeout(function () {
        $(".full-slider .left").removeClass("off");
        $(".full-slider .right").removeClass("off");
      }, 200);

      setTimeout(function () {
        $(".full-slider .left").addClass("init");
        $(".full-slider .right").addClass("init");
      }, 1000);
    } else {
      $(".full-slider .left").addClass("init");
      $(".full-slider .right").addClass("init");
    }
  };

  var fullSlider = new Swiper(".full-slider", {
    autoplay: {
      delay: 10000,
    },
    parallax: true,
    slidesPerView: 1,
    spaceBetween: 0,
    navigation: false,
    pagination: {
      el: ".full-slider .swiper-pagination",
      clickable: true,
    },
    keyboard: {
      enabled: true,
      onlyInViewport: false,
    },
    on: {
      init: function () {
        animation(".full-slider");
        let pagination = $(".full-slider .swiper-pagination");
        pagination.hide();

        setTimeout(function () {
          pagination.fadeIn("slow");
        }, 3600);
      },
      slideChange: function () {
        animation(".full-slider");

        let title = $(".full-slider .title");
        let description = $(".full-slider .description");
        let btn = $(".full-slider .buttons");

        title.attr("data-aos-delay", 400);
        description.attr("data-aos-delay", 800);
        btn.attr("data-aos-delay", 1200);
      },
    },
  });

  $(".mid-slider").each(function () {
    if ($(this).data("perview")) {
      var midPerView = $(this).data("perview");
    } else {
      var midPerView = 3;
    }

    var midSlider = new Swiper(this, {
      autoplay: false,
      loop: true,
      slidesPerView: 1,
      spaceBetween: 30,
      breakpoints: {
        767: {
          slidesPerView: 2,
          spaceBetween: 30,
        },
        1023: {
          slidesPerView: midPerView,
          spaceBetween: 30,
        },
      },
    });
  });

  $(".min-slider").each(function () {
    if ($(this).data("perview")) {
      var minPerView = $(this).data("perview");
    } else {
      var minPerView = 6;
    }

    var minSlider = new Swiper(this, {
      autoplay: {
        delay: 5000,
      },
      loop: false,
      centerInsufficientSlides: true,
      slidesPerView: 2,
      spaceBetween: 15,
      breakpoints: {
        424: {
          slidesPerView: 2,
          spaceBetween: 15,
        },
        767: {
          slidesPerView: 3,
          spaceBetween: 15,
        },
        1023: {
          slidesPerView: 4,
          spaceBetween: 15,
        },
        1199: {
          slidesPerView: minPerView,
          spaceBetween: 15,
        },
      },
      pagination: false,
    });
  });

  var noSlider = new Swiper(".no-slider", {
    autoplay: false,
    loop: false,
    keyboard: false,
    grabCursor: false,
    allowTouchMove: false,
    on: {
      init: function () {
        animation(".no-slider");
      },
    },
  });
});
jQuery(function ($) {
  "use strict";

  let preloader = $(".preloader");

  setTimeout(function () {
    preloader.addClass("ready");
  }, preloader.data("timeout"));
});

$(".owl-carousel").owlCarousel({
  loop: true,
  margin: 30,
  responsive: {
    0: {
      items: 1,
    },
    600: {
      items: 3,
    },
  },
});