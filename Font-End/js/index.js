$(function(){
    $(".menu > li > a").click(function (e) { 
        isOpen = $(this).next().hasClass("open");
        if(!isOpen){
            $(this).next().slideDown();
            $(this).next().addClass("open");
        }else{
            $(this).next().slideUp();
            $(this).next().removeClass("open");
        }
    });
})