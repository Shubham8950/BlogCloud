if(function(e){e(document).ready(function(){e(window).load(function(){e("body").removeClass("no-trans")});var o=navigator.platform.toLowerCase();0!=o.indexOf("win")&&0!=o.indexOf("linux")||Modernizr.touch||e.browser.webkit&&(e.webkitSmoothScroll(),console.log("hello webkit"));var t;if((Modernizr.mq("only all and (min-width: 768px)")&&!Modernizr.touch||e("html.ie8").length>0)&&e(".main-navigation .navbar-nav>li.dropdown, .main-navigation li.dropdown>ul>li.dropdown").hover(function(){var o=e(this);t=setTimeout(function(){o.addClass("open").slideDown(),o.find(".dropdown-toggle").addClass("disabled")},0)},function(){clearTimeout(t),e(this).removeClass("open"),e(this).find(".dropdown-toggle").removeClass("disabled")}),(Modernizr.mq("only all and (max-width: 767px)")||Modernizr.touch)&&e(".main-navigation [data-toggle=dropdown], .header-top [data-toggle=dropdown]").on("click",function(o){o.preventDefault(),o.stopPropagation(),e(this).parent().siblings().removeClass("open"),e(this).parent().siblings().find("[data-toggle=dropdown]").parent().removeClass("open"),e(this).parent().toggleClass("open")}),e(".slider-banner-container").length>0&&(e(".tp-bannertimer").show(),e(".slider-banner-container .slider-banner").show().revolution({delay:1e4,startwidth:1140,startheight:520,navigationArrows:"solo",navigationStyle:"round",navigationHAlign:"center",navigationVAlign:"bottom",navigationHOffset:0,navigationVOffset:20,soloArrowLeftHalign:"left",soloArrowLeftValign:"center",soloArrowLeftHOffset:20,soloArrowLeftVOffset:0,soloArrowRightHalign:"right",soloArrowRightValign:"center",soloArrowRightHOffset:20,soloArrowRightVOffset:0,fullWidth:"on",spinner:"spinner0",stopLoop:"off",stopAfterLoops:-1,stopAtSlide:-1,onHoverStop:"off",shuffle:"off",autoHeight:"off",forceFullWidth:"off",hideThumbsOnMobile:"off",hideNavDelayOnMobile:1500,hideBulletsOnMobile:"off",hCode2nightrrowsOnMobile:"off",hideThumbsUnderResolution:0,hideSliderAtLimit:0,hideCaptionAtLimit:0,hCode2nightllCaptionAtLilmit:0,startWithSlide:0}),e(".slider-banner-container .slider-banner-2").show().revolution({delay:1e4,startwidth:1140,startheight:520,navigationArrows:"solo",navigationStyle:"preview4",navigationHAlign:"center",navigationVAlign:"bottom",navigationHOffset:0,navigationVOffset:20,soloArrowLeftHalign:"left",soloArrowLeftValign:"center",soloArrowLeftHOffset:20,soloArrowLeftVOffset:0,soloArrowRightHalign:"right",soloArrowRightValign:"center",soloArrowRightHOffset:20,soloArrowRightVOffset:0,fullWidth:"on",spinner:"spinner0",stopLoop:"off",stopAfterLoops:-1,stopAtSlide:-1,onHoverStop:"off",shuffle:"off",autoHeight:"off",forceFullWidth:"off",hideThumbsOnMobile:"off",hideNavDelayOnMobile:1500,hideBulletsOnMobile:"off",hCode2nightrrowsOnMobile:"off",hideThumbsUnderResolution:0,hideSliderAtLimit:0,hideCaptionAtLimit:0,hCode2nightllCaptionAtLilmit:0,startWithSlide:0}),e(".slider-banner-container .slider-banner-3").show().revolution({delay:1e4,startwidth:1140,startheight:520,dottedOverlay:"twoxtwo",parallax:"mouse",parallaxBgFreeze:"on",parallaxLevels:[3,2,1],navigationArrows:"solo",navigationStyle:"preview5",navigationHAlign:"center",navigationVAlign:"bottom",navigationHOffset:0,navigationVOffset:20,soloArrowLeftHalign:"left",soloArrowLeftValign:"center",soloArrowLeftHOffset:20,soloArrowLeftVOffset:0,soloArrowRightHalign:"right",soloArrowRightValign:"center",soloArrowRightHOffset:20,soloArrowRightVOffset:0,fullWidth:"on",spinner:"spinner0",stopLoop:"off",stopAfterLoops:-1,stopAtSlide:-1,onHoverStop:"off",shuffle:"off",autoHeight:"off",forceFullWidth:"off",hideThumbsOnMobile:"off",hideNavDelayOnMobile:1500,hideBulletsOnMobile:"off",hCode2nightrrowsOnMobile:"off",hideThumbsUnderResolution:0,hideSliderAtLimit:0,hideCaptionAtLimit:0,hCode2nightllCaptionAtLilmit:0,startWithSlide:0}),e(".transparent.header").length>0||e(".offcanvas-container").length>0?e(".slider-banner-container .slider-banner-fullscreen").show().revolution({delay:1e4,startwidth:1140,startheight:520,fullWidth:"off",fullScreen:"on",fullScreenOffsetContainer:"",fullScreenOffset:"",navigationArrows:"solo",navigationStyle:"preview4",navigationHAlign:"center",navigationVAlign:"bottom",navigationHOffset:0,navigationVOffset:20,soloArrowLeftHalign:"left",soloArrowLeftValign:"center",soloArrowLeftHOffset:20,soloArrowLeftVOffset:0,soloArrowRightHalign:"right",soloArrowRightValign:"center",soloArrowRightHOffset:20,soloArrowRightVOffset:0,spinner:"spinner4",stopLoop:"off",stopAfterLoops:-1,stopAtSlide:-1,onHoverStop:"off",shuffle:"off",hideTimerBar:"on",autoHeight:"off",forceFullWidth:"off",hideThumbsOnMobile:"off",hideNavDelayOnMobile:1500,hideBulletsOnMobile:"off",hCode2nightrrowsOnMobile:"off",hideThumbsUnderResolution:0,hideSliderAtLimit:0,hideCaptionAtLimit:0,hCode2nightllCaptionAtLilmit:0,startWithSlide:0}):e(".slider-banner-container .slider-banner-fullscreen").show().revolution({delay:1e4,startwidth:1140,startheight:520,fullWidth:"off",fullScreen:"on",fullScreenOffsetContainer:"",fullScreenOffset:"82px",navigationArrows:"solo",navigationStyle:"preview4",navigationHAlign:"center",navigationVAlign:"bottom",navigationHOffset:0,navigationVOffset:20,soloArrowLeftHalign:"left",soloArrowLeftValign:"center",soloArrowLeftHOffset:20,soloArrowLeftVOffset:0,soloArrowRightHalign:"right",soloArrowRightValign:"center",soloArrowRightHOffset:20,soloArrowRightVOffset:0,spinner:"spinner4",stopLoop:"off",stopAfterLoops:-1,stopAtSlide:-1,onHoverStop:"off",shuffle:"off",hideTimerBar:"on",autoHeight:"off",forceFullWidth:"off",hideThumbsOnMobile:"off",hideNavDelayOnMobile:1500,hideBulletsOnMobile:"off",hCode2nightrrowsOnMobile:"off",hideThumbsUnderResolution:0,hideSliderAtLimit:0,hideCaptionAtLimit:0,hCode2nightllCaptionAtLilmit:0,startWithSlide:0}),e(".transparent.header").length>0||e(".offcanvas-container").length>0?e(".slider-banner-container .slider-banner-fullscreen-alt-nav").show().revolution({delay:1e4,startwidth:1140,startheight:520,fullWidth:"off",fullScreen:"on",fullScreenOffsetContainer:"",fullScreenOffset:"",navigationArrows:"solo",navigationStyle:"preview2",navigationHAlign:"center",navigationVAlign:"bottom",navigationHOffset:0,navigationVOffset:20,soloArrowLeftHalign:"left",soloArrowLeftValign:"center",soloArrowLeftHOffset:20,soloArrowLeftVOffset:0,soloArrowRightHalign:"right",soloArrowRightValign:"center",soloArrowRightHOffset:20,soloArrowRightVOffset:0,spinner:"spinner4",stopLoop:"off",stopAfterLoops:-1,stopAtSlide:-1,onHoverStop:"off",shuffle:"off",hideTimerBar:"on",autoHeight:"off",forceFullWidth:"off",hideThumbsOnMobile:"off",hideNavDelayOnMobile:1500,hideBulletsOnMobile:"off",hCode2nightrrowsOnMobile:"off",hideThumbsUnderResolution:0,hideSliderAtLimit:0,hideCaptionAtLimit:0,hCode2nightllCaptionAtLilmit:0,startWithSlide:0}):e(".slider-banner-container .slider-banner-fullscreen-alt-nav").show().revolution({delay:1e4,startwidth:1140,startheight:520,fullWidth:"off",fullScreen:"on",fullScreenOffsetContainer:"",fullScreenOffset:"82px",navigationArrows:"solo",navigationStyle:"preview2",navigationHAlign:"center",navigationVAlign:"bottom",navigationHOffset:0,navigationVOffset:20,soloArrowLeftHalign:"left",soloArrowLeftValign:"center",soloArrowLeftHOffset:20,soloArrowLeftVOffset:0,soloArrowRightHalign:"right",soloArrowRightValign:"center",soloArrowRightHOffset:20,soloArrowRightVOffset:0,spinner:"spinner4",stopLoop:"off",stopAfterLoops:-1,stopAtSlide:-1,onHoverStop:"off",shuffle:"off",hideTimerBar:"on",autoHeight:"off",forceFullWidth:"off",hideThumbsOnMobile:"off",hideNavDelayOnMobile:1500,hideBulletsOnMobile:"off",hCode2nightrrowsOnMobile:"off",hideThumbsUnderResolution:0,hideSliderAtLimit:0,hideCaptionAtLimit:0,hCode2nightllCaptionAtLilmit:0,startWithSlide:0})),e(".slider-revolution-5-container").length>0&&(e(".tp-bannertimer").show(),e(".slider-revolution-5-container .slider-banner-fullwidth").revolution({sliderType:"standard",sliderLayout:"fullwidth",delay:9e3,gridwidth:1140,gridheight:520,navigation:{onHoverStop:"off",arrows:{style:"hebe",enable:!0,tmp:'<div class="tp-title-wrap"><span class="tp-arr-titleholder">{{title}}</span></div>',left:{h_align:"left",v_align:"center",h_offset:0,v_offset:0},right:{h_align:"right",v_align:"center",h_offset:0,v_offset:0}},bullets:{style:"",enable:!0,hide_onleave:!0,direction:"horizontal",space:3,h_align:"center",v_align:"bottom",h_offset:0,v_offset:20}}}),e(".slider-revolution-5-container .slider-banner-boxedwidth").revolution({sliderType:"standard",sliderLayout:"auto",delay:8e3,gridwidth:1140,gridheight:520,shadow:1,navigation:{onHoverStop:"off",arrows:{style:"hebe",enable:!0,tmp:'<div class="tp-title-wrap"><span class="tp-arr-titleholder">{{title}}</span></div>',left:{h_align:"left",v_align:"center",h_offset:0,v_offset:0},right:{h_align:"right",v_align:"center",h_offset:0,v_offset:0}},bullets:{style:"",enable:!0,hide_onleave:!0,direction:"horizontal",space:3,h_align:"center",v_align:"bottom",h_offset:0,v_offset:20}}}),e(".transparent.header").length>0||e(".offcanvas-container").length>0?e(".slider-revolution-5-container .slider-banner-fullscreen").revolution({sliderType:"standard",sliderLayout:"fullscreen",delay:9e3,autoHeight:"on",fullScreenOffsetContainer:"",navigation:{onHoverStop:"off",arrows:{style:"hebe",enable:!0,tmp:'<div class="tp-title-wrap"><span class="tp-arr-titleholder">{{title}}</span></div>',left:{h_align:"left",v_align:"center",h_offset:0,v_offset:0},right:{h_align:"right",v_align:"center",h_offset:0,v_offset:0}},bullets:{style:"",enable:!0,hide_onleave:!0,direction:"horizontal",space:3,h_align:"center",v_align:"bottom",h_offset:0,v_offset:20}},gridwidth:1140,gridheight:750}):e(".slider-revolution-5-container .slider-banner-fullscreen").revolution({sliderType:"standard",sliderLayout:"fullscreen",delay:9e3,autoHeight:"on",fullScreenOffsetContainer:"header.header, .header-top",navigation:{onHoverStop:"off",arrows:{style:"hebe",enable:!0,tmp:'<div class="tp-title-wrap"><span class="tp-arr-titleholder">{{title}}</span></div>',left:{h_align:"left",v_align:"center",h_offset:0,v_offset:0},right:{h_align:"right",v_align:"center",h_offset:0,v_offset:0}},bullets:{style:"",enable:!0,hide_onleave:!0,direction:"horizontal",space:3,h_align:"center",v_align:"bottom",h_offset:0,v_offset:20}},gridwidth:1140,gridheight:750}),e(".slider-revolution-5-container .slider-banner-fullscreen-hero:not(.dotted)").revolution({sliderType:"hero",sliderLayout:"fullscreen",gridwidth:1140,gridheight:650,delay:9e3})),e(".owl-carousel").length>0&&(e(".owl-carousel.carousel").owlCarousel({items:4,pagination:!1,navigation:!0,navigationText:!1}),e(".owl-carousel.carousel-autoplay").owlCarousel({items:4,autoPlay:5e3,pagination:!1,navigation:!0,navigationText:!1}),e(".owl-carousel.clients").owlCarousel({items:4,autoPlay:!0,pagination:!1,itemsDesktopSmall:[992,5],itemsTablet:[768,4],itemsMobile:[479,3]}),e(".owl-carousel.content-slider").owlCarousel({singleItem:!0,autoPlay:5e3,navigation:!1,navigationText:!1,pagination:!1}),e(".owl-carousel.content-slider-with-controls").owlCarousel({singleItem:!0,autoPlay:!1,navigation:!0,navigationText:!1,pagination:!0}),e(".owl-carousel.content-slider-with-controls-autoplay").owlCarousel({singleItem:!0,autoPlay:5e3,navigation:!0,navigationText:!1,pagination:!0}),e(".owl-carousel.content-slider-with-controls-bottom").owlCarousel({singleItem:!0,autoPlay:!1,navigation:!0,navigationText:!1,pagination:!0})),e("[data-animation-effect]").length>0&&!Modernizr.touch&&e("[data-animation-effect]").each(function(){var o=e(this),t=o.attr("data-animation-effect");Modernizr.mq("only all and (min-width: 768px)")&&Modernizr.csstransitions?o.appear(function(){o.attr("data-effect-delay")&&o.css("effect-delay","0ms"),setTimeout(function(){o.addClass("animated object-visible "+t)},o.attr("data-effect-delay"))},{accX:0,accY:-130}):o.addClass("object-visible")}),e(".text-rotator").length>0&&e(".text-rotator").each(function(){var o=e(this).attr("data-rotator-animation-effect");e(this).Morphext({animation:""+o,separator:",",speed:5e3})}),e(".stats [data-to]").length>0&&e(".stats [data-to]").each(function(){var o=e(this),t=o.offset().top;e(window).scrollTop()>t-800&&!o.hasClass("counting")&&(o.addClass("counting"),o.countTo()),e(window).scroll(function(){e(window).scrollTop()>t-800&&!o.hasClass("counting")&&(o.addClass("counting"),o.countTo())})}),(e(".isotope-container").length>0||e(".masonry-grid").length>0||e(".masonry-grid-fitrows").length>0)&&e(window).load(function(){e(".masonry-grid").isotope({itemSelector:".masonry-grid-item",layoutMode:"masonry"}),e(".masonry-grid-fitrows").isotope({itemSelector:".masonry-grid-item",layoutMode:"fitRows"}),e(".isotope-container").fadeIn();var o=e(".isotope-container").isotope({itemSelector:".isotope-item",layoutMode:"masonry",transitionDuration:"0.6s",filter:"*"});e(".filters").on("click","ul.nav li a",function(){var t=e(this).attr("data-filter");return e(".filters").find("li.active").removeClass("active"),e(this).parent().addClass("active"),o.isotope({filter:t}),!1})}),e(".hc-tabs").length>0&&e(window).load(function(){var o=e(".hc-tabs .nav.nav-tabs li.active a").attr("href"),t=e(".hc-tabs-top").find("[data-tab='"+o+"']").attr("data-tab-animation-effect");e(".hc-tabs-top").find("[data-tab='"+o+"']").addClass("current-img show "+t+" animated"),e(".hc-tabs .nav.nav-tabs li a").on("click",function(o){var t=e(this).attr("href"),a=e(".hc-tabs-top").find("[data-tab='"+t+"']").attr("data-tab-animation-effect");e(".current-img").removeClass("current-img show "+a+" animated"),e(".hc-tabs-top").find("[data-tab='"+t+"']").addClass("current-img show "+a+" animated")})}),e("[data-animate-width]").length>0&&e("[data-animate-width]").each(function(){e(this).appear(function(){e(this).animate({width:e(this).attr("data-animate-width")},800)},{accX:0,accY:-100})}),e(".knob").length,e(".graph").length>0){var a=function(){return Math.round(500*Math.random())};if(e(".graph.line").length>0){var n={labels:["January","February","March","April","May","June","July"],datasets:[{label:"First dataset",backgroundColor:"rgba(188,188,188,0.2)",borderColor:"rgba(188,188,188,1)",pointBackgroundColor:"rgba(188,188,188,1)",pointBorderColor:"#fff",pointHoverBackgroundColor:"#fff",pointHoverBorderColor:"rgba(188,188,188,1)",data:[250,300,250,200,250,300,250]},{label:"Second dataset",backgroundColor:"rgba(126,187,205,0.2)",borderColor:"rgba(126,187,205,1)",pointBackgroundColor:"rgba(126,187,205,1)",pointBorderColor:"#fff",pointHoverBackgroundColor:"#fff",pointHoverBorderColor:"rgba(126,187,205,1)",data:[300,250,200,250,300,250,200]},{label:"Third dataset",backgroundColor:"rgba(98,187,205,0.2)",borderColor:"rgba(98,187,205,1)",pointBackgroundColor:"rgba(98,187,205,1)",pointBorderColor:"#fff",pointHoverBackgroundColor:"#fff",pointHoverBorderColor:"rgba(98,187,205,1)",data:[0,100,200,300,400,500,400]}]};e(window).load(function(){var e=document.getElementById("lines-graph").getContext("2d");window.newLine=new Chart(e,{type:"line",data:n,responsive:!0,bezierCurve:!1})})}if(e(".graph.bar").length>0){var r={labels:["January","February","March","April","May","June","July"],datasets:[{backgroundColor:"rgba(188,188,188,0.5)",borderColor:"rgba(188,188,188,0.8)",hoverBackgroundColor:"rgba(188,188,188,0.75)",hoverBorderColor:"rgba(188,188,188,1)",data:[a(),a(),a(),a(),a(),a(),a()]},{backgroundColor:"rgba(168,187,205,0.5)",borderColor:"rgba(168,187,205,0.8)",hoverBackgroundColor:"rgba(168,187,205,0.75)",hoverBorderColor:"rgba(168,187,205,1)",data:[a(),a(),a(),a(),a(),a(),a()]}]};e(window).load(function(){var e=document.getElementById("bars-graph").getContext("2d");window.myBar=new Chart(e,{type:"bar",data:r,responsive:!0})})}if(e(".graph.pie").length>0){var s={labels:["Red","Green","Yellow"],datasets:[{data:[300,50,100],backgroundColor:["#FF6384","#36A2EB","#FFCE56"],hoverBackgroundColor:["#FF6384","#36A2EB","#FFCE56"]}]};e(window).load(function(){var e=document.getElementById("pie-graph").getContext("2d");window.myPie=new Chart(e,{type:"pie",data:s,responsive:!0})})}if(e(".graph.doughnut").length>0){var l={labels:["Red","Green","Yellow"],datasets:[{data:[300,50,100],backgroundColor:["#FF6384","#36A2EB","#FFCE56"],hoverBackgroundColor:["#FF6384","#36A2EB","#FFCE56"]}]};e(window).load(function(){var e=document.getElementById("doughnut-graph").getContext("2d");window.myDoughnut=new Chart(e,{type:"doughnut",data:l,responsive:!0})})}}(e(".popup-img").length>0||e(".popup-iframe").length>0||e(".popup-img-single").length>0)&&(e(".popup-img").magnificPopup({type:"image",gallery:{enabled:!0}}),e(".popup-img-single").magnificPopup({type:"image",gallery:{enabled:!1}}),e(".popup-iframe").magnificPopup({disableOn:700,type:"iframe",preloader:!1,fixedContentPos:!1}));var d=e(".header-top").outerHeight(),f=e("header.header.fixed").outerHeight();if(e(window).scroll(function(){e(".header.fixed").length>0&&(e(this).scrollTop()>d+f&&e(window).width()>767?(e("body").addClass("fixed-header-on"),e(".header.fixed").addClass("animated object-visible fadeInDown"),e(".header.transparent").length>0||(e(".banner:not(.header-top)").length>0?e(".banner").css("marginTop",f+"px"):e(".page-intro").length>0?e(".page-intro").css("marginTop",f+"px"):e(".page-top").length>0?e(".page-top").css("marginTop",f+"px"):e("section.main-container").css("marginTop",f+"px"))):(e("body").removeClass("fixed-header-on"),e("section.main-container").css("marginTop","0px"),e(".banner").css("marginTop","0px"),e(".page-intro").css("marginTop","0px"),e(".page-top").css("marginTop","0px"),e(".header.fixed").removeClass("animated object-visible fadeInDown")))}),e("#share").length>0){var h=["facebook","twitter"];e("#share").sharrre({share:{facebook:!0,twitter:!0},buttons:{facebook:{popup:{width:1200,height:900}},twitter:{}},enableCounter:!1,enableHover:!1,template:'<ul class="social-links clearfix"><li class="facebook"><a href="#"><i class="fa fa-facebook"></i></a></li><li class="twitter"><a href="#"><i class="fa fa-twitter"></i></a></li></ul>',render:function(o,t){for(i in h)service=h[i],e(o.element).on("click","."+service,function(){o.openPopup(this.className)})}})}e("#contact-form").length>0&&e("#contact-form").validate({submitHandler:function(o){e(".submit-button").button("loading"),e.ajax({type:"POST",url:"php/email-sender.php",data:{name:e("#contact-form #name").val(),email:e("#contact-form #email").val(),subject:e("#contact-form #subject").val(),message:e("#contact-form #message").val()},dataType:"json",success:function(o){"yes"==o.sent?(e("#MessageSent").removeClass("hidden"),e("#MessageNotSent").addClass("hidden"),e(".submit-button").removeClass("btn-default").addClass("btn-success").prop("value","Message Sent"),e("#contact-form .form-control").each(function(){e(this).prop("value","").parent().removeClass("has-success").removeClass("has-error")})):(e("#MessageNotSent").removeClass("hidden"),e("#MessageSent").addClass("hidden"))}})},errorPlacement:function(e,o){e.insertBefore(o)},onkeyup:!1,onclick:!1,rules:{name:{required:!0,minlength:2},email:{required:!0,email:!0},subject:{required:!0},message:{required:!0,minlength:10}},messages:{name:{required:"Please specify your name",minlength:"Your name must be longer than 2 characters"},email:{required:"We need your email address to contact you",email:"Please enter a valid email address e.g. name@domain.com"},subject:{required:"Please enter a subject"},message:{required:"Please enter a message",minlength:"Your message must be longer than 10 characters"}},errorElement:"span",highlight:function(o){e(o).parent().removeClass("has-success").addClass("has-error"),e(o).siblings("label").addClass("hide")},success:function(o){e(o).parent().removeClass("has-error").addClass("has-success"),e(o).siblings("label").removeClass("hide")}}),e("#contact-form-with-recaptcha").length>0&&e("#contact-form-with-recaptcha").validate({submitHandler:function(o){e(".submit-button").button("loading"),e.ajax({type:"POST",url:"php/email-sender-recaptcha.php",data:{name:e("#contact-form-with-recaptcha #name").val(),email:e("#contact-form-with-recaptcha #email").val(),subject:e("#contact-form-with-recaptcha #subject").val(),message:e("#contact-form-with-recaptcha #message").val(),"g-recaptcha-response":e("#g-recaptcha-response").val()},dataType:"json",success:function(o){"yes"==o.sent?(e("#MessageSent").removeClass("hidden"),e("#MessageNotSent").addClass("hidden"),e(".submit-button").removeClass("btn-default").addClass("btn-success").prop("value","Message Sent"),e("#contact-form-with-recaptcha .form-control").each(function(){e(this).prop("value","").parent().removeClass("has-success").removeClass("has-error")})):(e("#MessageNotSent").removeClass("hidden"),e("#MessageSent").addClass("hidden"))}})},errorPlacement:function(e,o){e.insertBefore(o)},onkeyup:!1,onclick:!1,rules:{name:{required:!0,minlength:2},email:{required:!0,email:!0},subject:{required:!0},message:{required:!0,minlength:10}},messages:{name:{required:"Please specify your name",minlength:"Your name must be longer than 2 characters"},email:{required:"We need your email address to contact you",email:"Please enter a valid email address e.g. name@domain.com"},subject:{required:"Please enter a subject"},message:{required:"Please enter a message",minlength:"Your message must be longer than 10 characters"}},errorElement:"span",highlight:function(o){e(o).parent().removeClass("has-success").addClass("has-error"),e(o).siblings("label").addClass("hide")},success:function(o){e(o).parent().removeClass("has-error").addClass("has-success"),e(o).siblings("label").removeClass("hide")}}),e("#footer-form").length>0&&e("#footer-form").validate({submitHandler:function(o){e(".submit-button").button("loading"),e.ajax({type:"POST",url:"php/email-sender.php",data:{name:e("#footer-form #name2").val(),email:e("#footer-form #email2").val(),subject:"Message from contact form",message:e("#footer-form #message2").val()},dataType:"json",success:function(o){"yes"==o.sent?(e("#MessageSent2").removeClass("hidden"),e("#MessageNotSent2").addClass("hidden"),e(".submit-button").removeClass("btn-default").addClass("btn-success").prop("value","Message Sent"),e("#footer-form .form-control").each(function(){e(this).prop("value","").parent().removeClass("has-success").removeClass("has-error")})):(e("#MessageNotSent2").removeClass("hidden"),e("#MessageSent2").addClass("hidden"))}})},errorPlacement:function(e,o){e.insertAfter(o)},onkeyup:!1,onclick:!1,rules:{name2:{required:!0,minlength:2},email2:{required:!0,email:!0},message2:{required:!0,minlength:10}},messages:{name2:{required:"Please specify your name",minlength:"Your name must be longer than 2 characters"},email2:{required:"We need your email address to contact you",email:"Please enter a valid email address e.g. name@domain.com"},message2:{required:"Please enter a message",minlength:"Your message must be longer than 10 characters"}},errorElement:"span",highlight:function(o){e(o).parent().removeClass("has-success").addClass("has-error"),e(o).siblings("label").addClass("hide")},success:function(o){e(o).parent().removeClass("has-error").addClass("has-success"),e(o).siblings("label").removeClass("hide")}}),e("#sidebar-form").length>0&&e("#sidebar-form").validate({submitHandler:function(o){e(".submit-button").button("loading"),e.ajax({type:"POST",url:"php/email-sender.php",data:{name:e("#sidebar-form #name3").val(),email:e("#sidebar-form #email3").val(),subject:"Message from FAQ page",category:e("#sidebar-form #category").val(),message:e("#sidebar-form #message3").val()},dataType:"json",success:function(o){"yes"==o.sent?(e("#MessageSent3").removeClass("hidden"),e("#MessageNotSent3").addClass("hidden"),e(".submit-button").removeClass("btn-default").addClass("btn-success").prop("value","Message Sent"),e("#sidebar-form .form-control").each(function(){e(this).prop("value","").parent().removeClass("has-success").removeClass("has-error")})):(e("#MessageNotSent3").removeClass("hidden"),e("#MessageSent3").addClass("hidden"))}})},errorPlacement:function(e,o){e.insertAfter(o)},onkeyup:!1,onclick:!1,rules:{name3:{required:!0,minlength:2},email3:{required:!0,email:!0},message3:{required:!0,minlength:10}},messages:{name3:{required:"Please specify your name",minlength:"Your name must be longer than 2 characters"},email3:{required:"We need your email address to contact you",email:"Please enter a valid email address e.g. name@domain.com"},message3:{required:"Please enter a message",minlength:"Your message must be longer than 10 characters"}},errorElement:"span",highlight:function(o){e(o).parent().removeClass("has-success").addClass("has-error")},success:function(o){e(o).parent().removeClass("has-error").addClass("has-success")}}),e("#affix").length>0&&e(window).load(function(){var o=e(".footer").outerHeight(!0)+e(".subfooter").outerHeight(!0)+e(".blogpost footer").outerHeight(!0),t=e("#affix").offset().top;e(".comments").length>0&&(o+=e(".comments").outerHeight(!0)),e(".comments-form").length>0&&(o+=e(".comments-form").outerHeight(!0)),e(".footer-top").length>0&&(o+=e(".footer-top").outerHeight(!0)),e(".header.fixed").length>0?e("#affix").affix({offset:{top:t-150,bottom:o+100}}):e("#affix").affix({offset:{top:t-35,bottom:o+100}})}),e(".affix-menu").length>0&&setTimeout(function(){var o=e(".sidebar");o.affix({offset:{top:function(){var e=o.offset().top;return this.top=e-65},bottom:function(){var o=e(".footer").outerHeight(!0)+e(".subfooter").outerHeight(!0);return e(".footer-top").length>0&&(o+=e(".footer-top").outerHeight(!0)),this.bottom=o+50}}})},100),e(".smooth-scroll").length>0&&(e(".header.fixed").length>0?e(".smooth-scroll a, a.smooth-scroll").click(function(){if(location.pathname.replace(/^\//,"")==this.pathname.replace(/^\//,"")&&location.hostname==this.hostname){var o=e(this.hash);if((o=o.length?o:e("[name="+this.hash.slice(1)+"]")).length)return e("html,body").animate({scrollTop:o.offset().top-65},1e3),!1}}):e(".smooth-scroll a, a.smooth-scroll").click(function(){if(location.pathname.replace(/^\//,"")==this.pathname.replace(/^\//,"")&&location.hostname==this.hostname){var o=e(this.hash);if((o=o.length?o:e("[name="+this.hash.slice(1)+"]")).length)return e("html,body").animate({scrollTop:o.offset().top},1e3),!1}})),e(".scrollspy").length>0&&(e("body").addClass("scroll-spy"),e(".fixed.header").length>0?e("body").scrollspy({target:".scrollspy",offset:85}):e("body").scrollspy({target:".scrollspy",offset:20})),e(".video-background").length>0&&(Modernizr.touch?e(".video-background").vide({mp4:"videos/background-video.mp4",webm:"videos/background-video.webm",poster:"videos/video-fallback.jpg"},{volume:1,playbackRate:1,muted:!0,loop:!0,autoplay:!0,position:"50% 60%",posterType:"jpg",resizing:!0}):e(".video-background").vide({mp4:"videos/background-video.mp4",webm:"videos/background-video.webm",poster:"videos/video-poster.jpg"},{volume:1,playbackRate:1,muted:!0,loop:!0,autoplay:!0,position:"50% 60%",posterType:"jpg",resizing:!0})),e(window).scroll(function(){0!=e(this).scrollTop()?e(".scrollToTop").fadeIn():e(".scrollToTop").fadeOut()}),e(".scrollToTop").click(function(){e("body,html").animate({scrollTop:0},800)}),e(".modal").length>0&&e(".modal").each(function(){e(".modal").prependTo("body")}),e(".pricing-tables").length>0&&e(".plan .pt-popover").popover({trigger:"hover"}),e(".parallax").length>0&&!Modernizr.touch&&e(".parallax").parallax("50%",.2,!1),e(".parallax-2").length>0&&!Modernizr.touch&&e(".parallax-2").parallax("50%",.2,!1),e(".parallax-text").length>0&&!Modernizr.touch&&e(window).scroll(function(){scrollPos=e(this).scrollTop(),e(".parallax-text").css({opacity:1-scrollPos/400})}),e(".btn-remove").click(function(){e(this).closest(".remove-data").remove()}),e("#shipping-info-check").is(":checked")&&e("#shipping-information").hide(),e("#shipping-info-check").change(function(){e(this).is(":checked"),e("#shipping-information").slideToggle()}),e(".header-top .dropdown-menu input").click(function(e){e.stopPropagation()}),e("#offcanvas").length>0&&e("#offcanvas").offcanvas({disableScrolling:!1,toggle:!1}),e("#offcanvas").length>0&&e("#offcanvas [data-toggle=dropdown]").on("click",function(o){o.preventDefault(),o.stopPropagation(),e(this).parent().siblings().removeClass("open"),e(this).parent().siblings().find("[data-toggle=dropdown]").parent().removeClass("open"),e(this).parent().toggleClass("open")})})}(this.jQuery),jQuery(".btn-print").length>0)function print_window(){var e=window;e.document.close(),e.focus(),e.print(),e.close()}!function(e,o,t,a,n,i,r){e.GoogleAnalyticsObject=n,e.ga=e.ga||function(){(e.ga.q=e.ga.q||[]).push(arguments)},e.ga.l=1*new Date,i=o.createElement(t),r=o.getElementsByTagName(t)[0],i.async=1,i.src="//www.google-analytics.com/analytics.js",r.parentNode.insertBefore(i,r)}(window,document,"script",0,"ga"),ga("create","UA-40620479-6","auto"),ga("send","pageview");