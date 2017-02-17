$(document).ready(function () {

    $("a.switcher").on("click", function (e) {
        e.preventDefault();

        var theid = $(this).attr("data-view");
        var theproperties = $(".ezsearch-results");
        var classNames = $(this).attr('class').split(' ');

        if ($(this).hasClass("active")) {
            // if currently clicked button has the active class
            // then we do nothing!
            return false;
        }
        else {
            // otherwise we are clicking on the inactive button
            // and in the process of switching views!

            if (theid == "grid-view") {
                $(this).addClass("active");
                $("#list").removeClass("active");

                // remove the list class and change to grid
                theproperties.removeClass("list");
                theproperties.removeAttr('data-view', 'list-view');
                theproperties.addClass("grid");
                theproperties.attr('data-view', 'grid-view');

                // update all thumbnails to larger size
                //$("img.thumb").attr("src", gridthumb);
            }

            else if (theid == "list-view") {
                $(this).addClass("active");
                $("#grid").removeClass("active");

                //var theimg = $(this).children("img");
                //theimg.attr("src", "images/list-view-active.png");
                // remove the grid view and change to list
                theproperties.removeClass("grid");
                theproperties.removeAttr('data-view', 'grid-view');
                theproperties.addClass("list");
                theproperties.attr('data-view', 'list-view');
                // update all thumbnails to smaller size
                //$("img.thumb").attr("src", listthumb);
            }
        }

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