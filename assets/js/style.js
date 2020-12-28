$(document).ready(function () {
    $('.contact__block').each(function () {
        $(this).click(function () {
            $('.contact__block').toggleClass('d-none');
            $('.language').toggleClass('d-none');
            $(this).removeClass('d-none');
            $(this).parent().find('.contact__info').toggleClass('d-block');
        });
    });
    var sec = $('.sec').html();
    var min = $('.min').html();
    var hour = $('.hour').html();
    var day = $('.day').html();
    setInterval(function () {
        sec -= 1;
        if (sec == -1) {
            sec = 59;
            min -= 1;
            if (min == -1) {
                min = 59;
                hour -= 1;
                if (hour == -1) {
                    hour = 23;
                    day -= 1;
                }
            }
        }
        $('.sec').html(sec);
        $('.min').html(min);
        $('.hour').html(hour);
        $('.day').html(day);
    }, 1000);

    $('.category__icon').click(function () {
        $('.category__menu').slideToggle();
    });
    $('.hidden-menu__btn').click(function () {
        $('.menu-bar').slideToggle();
    });
    $('.product__list').slick({
        dots: false,
        infinite: true,
        rows: 2,
        slidesToShow: 4,
        responsive: [
            {
                breakpoint: 992,
                settings: {
                    slidesToShow: 3,
                }
            },
            {
                breakpoint: 576,
                settings: {
                    slidesToShow: 1,
                }
            }
        ]
    });
    $(".arrival__list").slick({
        dots: false,
        infinite: true,
        slidesToShow: 4,
        responsive: [
            {
                breakpoint: 992,
                settings: {
                    slidesToShow: 2,
                }
            },
            {
                breakpoint: 576,
                settings: {
                    slidesToShow: 1
                }
            }
        ]
    });

});