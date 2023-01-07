$(".btn-show-mercy").click(function (e) { 
    e.preventDefault();
    $(".adieu").fadeOut(function(){
        $(".bonjour").fadeIn();
    });

});