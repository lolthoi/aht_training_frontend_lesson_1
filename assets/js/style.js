$(document).ready(function () {
    $('.contact__block').each(function () {
        $(this).click(function () {
            $('.contact__block').toggleClass('d-none');
            $('.language').toggleClass('d-none');
            $(this).removeClass('d-none');
            $(this).parent().find('.contact__info').toggleClass('d-block');
        });
    });

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
        variableWidth: true,
        responsive: [
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 2
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
    $(".arrival__list").slick({
        dots: false,
        infinite: true,
        slidesToShow: 4,
        variableWidth: true,
        responsive: [
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 2,
                    variableWidth: true,
                }
            },
            {
                breakpoint: 576,
                settings: {
                    slidesToShow: 1,
                    variableWidth: true,
                }
            }
        ]
    });

});