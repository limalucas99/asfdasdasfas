(function($){ //dolar será o objeto padrão
    
    $('.paroller').paroller()
    var contentWaypoint = function(){
        //selecionar o elemento que será animado, nesse caso é a classe .element-animate
        $('.element-animate').waypoint( function( direction ){//a função recebe um parametro c a direction
            console.log(direction);
            console.log(this);
            console.log(this.element);
            
            const $element = $(this.element);
            let effect = $element.data('animate-effect') || 'fadeInUp';
                        
            //if(direction === 'down') = se o usuário estiver rolando o scroll para baixo
            
            if(direction === 'down' && !$element.hasClass('element-animated')){
                $element.removeClass('element-animate').addClass('element-animated ' + effect)
            }
        }, {
            offset: '90%'
        })
    }
    
    contentWaypoint()
})(jQuery)

//div Detalhes
$('.card').on("mousemove mouseleave", function( event ) {
       var divid = "#detalhes";
   if(event.type == "mouseleave"){
      $(divid).hide();
   }else{
      var divid_height = $(divid).height(); // altura da div
      var scrolTop = $(window).scrollTop(); // scroll da janela
      $(divid).css({
         top: event.clientY-divid_height+scrolTop,
         left: event.clientX+5
      }).show()
   }
 })
    
 
//fim div detalhes
//--------------------------------------------------------------------------------------------------//
 
   let navLink = $('.barra-animada');
    
    navLink.on('click',function(e){
        e.preventDefault(); //tiro o comportamento padrão, que é ir direto pra onde cliquei
          let href = $(this).attr('href'); //pego o elemento href de onde cliquei
          let alvo = $(href); //alvo, pra onde eu quero ir
          let pos = alvo.position().top; //pega a posição do top de onde quero ir 
          
          $('html, body').animate({scrollTop: pos}, 1500); //animo o scroll
    })



//-----------------------------------------------------------//