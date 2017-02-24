$(document).ready(function () {

    $('#list').click(function (event) {
        event.preventDefault();
        $('#products .item').addClass('list-group-item');
    });
        $('#grid').click(function (event) {
            event.preventDefault();
            $('#products .item').removeClass('list-group-item');
            $('#products .item').addClass('grid-group-item');
        });

    $('#orderby').on('changed.bs.select', function (event) {

        var currentUrl = window.location.href;

        if (currentUrl.indexOf('?orderby=')) {

            //url = url.slice(0, url.indexOf('&'));
            var parsedUrl = $.url(currentUrl);
            var currentOrder = url('?orderby', parsedUrl);
            //if (url.match("your string").length > 0) {
            var newOrder = $(this).val();

            var newUrl = location.href.replace("orderby=" + currentOrder, "orderby=" + newOrder);
            window.location.href = newUrl;
        }
        //else {
        //    var params = { 'orderby': $(this).val() };
        //    window.location.href = currentUrl + '?' + jQuery.param(params);
        //}

    });

    var currentUrl = window.location.href;
    var parsedUrl = $.url(currentUrl);

    var order = url('?orderby', parsedUrl);//$.url.attr('orderby');//$.url().param('?orderby');
    var region = url('?Location', parsedUrl);
    var minBeds = url('?MinBedrooms', parsedUrl);
    var minPrice = url('?MinPrice', parsedUrl);
    var maxPrice = url('?MaxPrice', parsedUrl);

    $('.selectpicker').val(order);

    $('[name="Location"]').val(region);

    $('[name="MinBedrooms"]').val(minBeds);

    $('[name="MinPrice"]').val(minPrice);

    $('[name="MaxPrice"]').val(maxPrice);
    //
    $('.selectpicker').selectpicker('render');

    if (/Android|webOS|iPhone|iPad|iPod|BlackBerry/i.test(navigator.userAgent)) {
        $('.selectpicker').selectpicker('mobile');
    }
});