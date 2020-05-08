@Code
    ViewData("Title") = "Home Page"
End Code

<!--  ======================= Start Main Area ================================ -->
<main class="site-main">
    <section class="site-banner">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-12 site-title">
                    <h3 class="title-text">Welcome To My Store</h3>
                    <h1 class="title-text">New Computers For Sale</h1>
                    <div class="site-buttons">
                        <div class="d-flex flex-row flex-wrap">
                            <button type="button" class="btn button btn-warning mr-4 text-uppercase">Shop Now</button>
                        </div>
                    </div>
                    <div id="outbox">
                        <div id="date"></div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id="content">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2>Check Our New Specials</h2>
                    <hr>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    <h3>For Sale Specials</h3>
                    <p>
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit.
                        Modi facere explicabo soluta incidunt ab eligendi quo
                        laborum hic corrupti vero ratione fugiat aspernatur,
                        sequi qui in labore! Debitis, accusamus architecto.
                    </p>
                </div>
                <div class="col-sm-6">
                    <!--carousel-area-->
                    <article class="carousel">
                        <div class="container" id="outside-container">
                            <div class="inner">
                                <img src="~/Content/Images/1.png" class="img-responsive slideshow">
                                <img src="~/Content/Images/2.png" class="img-responsive slideshow">
                                <img src="~/Content/Images/3.jpg" class="img-responsive slideshow">
                            </div>
                        </div>
                    </article>
                </div>
            </div>
        </div>

    </section>

    <!--  ======================= Thumbnail area =============================  -->

    <section id="thumbnail">
        <div class="container">
            <div class="main-img">
                <img src="~/Content/Images/1.png" id="current" />
            </div>
            <div class="imgs">
                <img src="~/Content/Images/1.png" />
                <img src="~/Content/Images/2.png" />
                <img src="~/Content/Images/3.jpg" />
            </div>
        </div>
    </section>


    <!--  ======================= Thumbnail area End =============================  -->

    <section id="deals">
        <div class="container">
            <div class="row">
                <div class="col lg-12">
                    <h2>Cyber Deals!!</h2>
                </div>
            </div>
            <div class="row text-center">
                <div class="col-sm-3 inner-deals">
                    <img src="~/Content/Images/1.png">
                    <button data-modal-target="#modal" class="btn btn-danger more-details">Tech Details</button>
                    <div class="modal" id="modal" style="display:block">
                        <div class="modal-header">
                            <div class="title">Electronics</div>
                            <button data-close-button class="close-button">&times;</button>
                        </div>
                        <img id="image-modal" src="~/Content/Images/1.png" class="img-responsive">
                        <div class="modal-body">
                            Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        </div>
                    </div>
                    <div id="overlay"></div>
                </div>
                <div class="col-sm-3 inner-deals">
                    <img src="~/Content/Images/2.png" alt="">
                    <button data-modal-target="#modal" class="btn btn-danger more-details">Games Details</button>
                    <div class="modal" id="modal" style="display:block">
                        <div class="modal-header">
                            <div class="title">Games</div>
                            <button data-close-button class="close-button">&times;</button>
                        </div>
                        <img id="image-modal" src="~/Content/Images/2.png" class="img-responsive">
                        <div class="modal-body">
                            Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        </div>
                    </div>
                    <div id="overlay"></div>
                </div>
                <div class="col-sm-3 inner-deals">
                    <img src="~/Content/Images/3.jpg" alt="">
                    <button data-modal-target="#modal" class="btn btn-danger more-details">Electronics Details</button>
                    <div class="modal" id="modal" style="display:block">
                        <div class="modal-header">
                            <div class="title">Electronics</div>
                            <button data-close-button class="close-button">&times;</button>
                        </div>
                        <img id="image-modal" src="~/Content/Images/3.jpg" class="img-responsive">
                        <div class="modal-body">
                            Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        </div>
                    </div>
                    <div id="overlay"></div>
                </div>
                <div class="col-sm-3 inner-deals">
                    <img src="~/Content/Images/4.jpg" alt="">
                    <button data-modal-target="#modal" class="btn btn-danger more-details">Repair Kits Details</button>
                    <div class="modal" id="modal" style="display:block">
                        <div class="modal-header">
                            <div class="title">Electronics</div>
                            <button data-close-button class="close-button">&times;</button>
                        </div>
                        <img id="image-modal" src="~/Content/Images/4.jpg" class="img-responsive">
                        <div class="modal-body">
                            Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        </div>
                    </div>
                    <div id="overlay"></div>
                </div>
            </div>
        </div>
    </section>

    <!--  ======================= Project Area =============================  -->

    <section class="project-area">
        <div class="container">
            <div class="project-title pb-5">
                <h1 class="text-uppercase title-h1">Check By Categories</h1>
                <h1 class="text-uppercase title-h1">Best Quality Products</h1>
            </div>

            <div class="button-group">
                <button type="button" class="active" id="btn1" data-filter="*">All</button>
                <button type="button" data-filter=".popular">Popular</button>
                <button type="button" data-filter=".latest">Latest</button>
                <button type="button" data-filter=".following">Following</button>
                <button type="button" data-filter=".upcoming">Upcoming</button>
            </div>

            <div class="row grid">
                <div class="col-lg-4 col-md-6 col-sm-12 element-item latest">
                    <div class="our-project">
                        <div class="img">
                            <a class="test-popup-link" href="~/Content/Images/10.jpg">
                                <img src="~/Content/Images/10.jpg" class="sc-item-img img-fluid" />
                            </a>
                        </div>
                        <div class="title py-4">
                            <h4 class="text-uppercase">Apple Laptop</h4>
                            <span class="text-secondary">$999.99</span>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-12 element-item popular">
                    <div class="our-project">
                        <div class="img">
                            <a class="test-popup-link" href="~/Content/Images/11.jpg">
                                <img src="~/Content/Images/11.jpg" class="sc-item-img img-fluid" />
                            </a>
                        </div>
                        <div class="title py-4">
                            <h4 class="text-uppercase">apple Tablets</h4>
                            <span class="text-secondary">$699.99</span>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-12 element-item popular">
                    <div class="our-project">
                        <div class="img">
                            <a class="test-popup-link" href="~/Content/Images/12.jpg">
                                <img src="~/Content/Images/12.jpg" alt="portfolio-3" class="img-fluid">
                            </a>
                        </div>
                        <div class="title py-4">
                            <h4 class="text-uppercase">Iphone</h4>
                            <span class="text-secondary">$599.99</span>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-12 element-item upcoming">
                    <div class="our-project">
                        <div class="img">
                            <a class="test-popup-link" href="~/Content/Images/13.jpg">
                                <img src="~/Content/Images/13.jpg" alt="portfolio-4" class="img-fluid">
                            </a>
                        </div>
                        <div class="title py-4">
                            <h4 class="text-uppercase">Apple Desktops</h4>
                            <span class="text-secondary">$599.99</span>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-12 element-item upcoming">
                    <div class="our-project">
                        <div class="img">
                            <a class="test-popup-link" href="~/Content/Images/14.jpg">
                                <img src="~/Content/Images/14.jpg" alt="portfolio-5" class="img-fluid">
                            </a>
                        </div>
                        <div class="title py-4">
                            <h4 class="text-uppercase">Apple Watch</h4>
                            <span class="text-secondary">$299.99</span>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-12 element-item following">
                    <div class="our-project">
                        <div class="img">
                            <a class="test-popup-link" href="~/Content/Images/15.jpg">
                                <img src="~/Content/Images/15.jpg" alt="portfolio-6" class="img-fluid">
                            </a>
                        </div>
                        <div class="title py-4">
                            <h4 class="text-uppercase">Apple Credit Machine</h4>
                            <span class="text-secondary">$290.99</span>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-12 element-item following">
                    <div class="our-project">
                        <div class="img">
                            <a class="test-popup-link" href="~/Content/Images/16.jpg">
                                <img src="~/Content/Images/16.jpg" alt="portfolio-7" class="img-fluid">
                            </a>
                        </div>
                        <div class="title py-4">
                            <h4 class="text-uppercase">drones</h4>
                            <span class="text-secondary">$699.12</span>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-12 element-item following">
                    <div class="our-project">
                        <div class="img">
                            <a class="test-popup-link" href="~/Content/Images/12.jpg">
                                <img src="~/Content/Images/12.jpg" alt="portfolio-8" class="img-fluid">
                            </a>
                        </div>
                        <div class="title py-4">
                            <h4 class="text-uppercase">X-PHones</h4>
                            <span class="text-secondary">$999.12</span>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 col-sm-12 element-item upcoming">
                    <div class="our-project">
                        <div class="img">
                            <a class="test-popup-link" href="~/Content/Images/13.jpg">
                                <img src="~/Content/Images/13.jpg" alt="portfolio-9" class="img-fluid">
                            </a>
                        </div>
                        <div class="title py-4">
                            <h4 class="text-uppercase">Desktops</h4>
                            <span class="text-secondary">$899.12</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!--  ======================= End Project Area =============================  -->
    <section id="deals">
        <div class="container">
            <div class="row">
                <div class="col lg-12">
                    <h2>More Cyber Deals!!</h2>
                </div>
            </div>
            <div class="row text-center">
                <div class="col-sm-3 inner-deals">
                    <img src="~/Content/Images/5.jpg" alt="">
                    <button data-modal-target="#modal" class="btn btn-danger more-details">Tech Details</button>
                    <div class="modal" id="modal" style="display:block">
                        <div class="modal-header">
                            <div class="title">Electronics</div>
                            <button data-close-button class="close-button">&times;</button>
                        </div>
                        <img id="image-modal" src="~/Content/Images/1.png" class="img-responsive">
                        <div class="modal-body">
                            Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        </div>
                    </div>
                    <div id="overlay"></div>
                </div>
                <div class="col-sm-3 inner-deals">
                    <img src="~/Content/Images/6.jpg" alt="">
                    <button data-modal-target="#modal" class="btn btn-danger more-details">Games Details</button>
                    <div class="modal" id="modal" style="display:block">
                        <div class="modal-header">
                            <div class="title">Electronics</div>
                            <button data-close-button class="close-button">&times;</button>
                        </div>
                        <img id="image-modal" src="images/1.png" class="img-responsive">
                        <div class="modal-body">
                            Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        </div>
                    </div>
                    <div id="overlay"></div>
                </div>
                <div class="col-sm-3 inner-deals">
                    <img src="~/Content/Images/7.jpg" alt="">
                    <button data-modal-target="#modal" class="btn btn-danger more-details">Electronics Details</button>
                    <div class="modal" id="modal" style="display:block">
                        <div class="modal-header">
                            <div class="title">Electronics</div>
                            <button data-close-button class="close-button">&times;</button>
                        </div>
                        <img id="image-modal" src="images/1.png" class="img-responsive">
                        <div class="modal-body">
                            Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        </div>
                    </div>
                    <div id="overlay"></div>
                </div>
                <div class="col-sm-3 inner-deals">
                    <img src="~/Content/Images/8.jpg" alt="">
                    <button data-modal-target="#modal" class="btn btn-danger more-details">Repair Kits Details</button>
                    <div class="modal" id="modal" style="display:block">
                        <div class="modal-header">
                            <div class="title">Electronics</div>
                            <button data-close-button class="close-button">&times;</button>
                        </div>
                        <img id="image-modal" src="images/1.png" class="img-responsive">
                        <div class="modal-body">
                            Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        </div>
                    </div>
                    <div id="overlay"></div>
                </div>
            </div>
        </div>
    </section>
    <section id="products">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h2 class="products-header">Our Products</h2>
                    <hr>
                </div>
            </div>
            <div id="main-box" class="row main-box"></div>
        </div>
    </section>
    <section id="select">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2>Select Your Item</h2>
                    <hr>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 col-sm-6">
                    <a class="btn btn-primary" onclick="setEven()">Even</a>
                    <a class="btn btn-primary" onclick="setOdd()">Odd</a>
                    <a class="btn btn-primary" onclick="setFirst4()">First 4</a>
                    <p class="label">Electronics</p>
                    <ul id="items">
                        <li>Tele</li>
                        <li>Computer</li>
                        <li>Iphone</li>
                        <li>Ps2</li>
                        <li>Xbox</li>
                        <li>Laptop</li>
                        <li>Movies</li>
                        <li>Games</li>
                    </ul>
                </div>
                <div class="col-md-6 col-sm-6">
                    <div class="widget">
                        <div class="time">
                            <p id="week" class="week"></p>
                            <p id="month" class="month"></p>
                            <p>-</p>
                            <p id="day" class="day"></p>
                            <p>of</p>
                            <p id="year" class="year"></p>
                        </div>
                        <div class="clock">
                            <p id="hour" class="hour"></p>
                            <p>:</p>
                            <p id="minutes" class="minutes"></p>
                            <p>:</p>
                            <div class="seconds-box">
                                <p id="ampm" class="ampm"></p>
                                <p id="seconds" class="seconds"></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id="specials">
        <div class="container">
            <div class="row">
                <h2>Specials</h2>
                <hr>
            </div>
            <div class="row text-center">
                <div class="col-md-3 col-sm-3">
                    <div class="gallery">
                        <a class="test-popup-link" href="images/10.jpg">
                            <img src="~/Content/Images/10.jpg" alt="" class="img-fluid">
                        </a>

                        <h4>Free shipping</h4>
                        <button class="btn btn-md">Shop Now</button>
                    </div>
                </div>
                <div class="col-md-3 col-sm-3">
                    <img src="~/Content/Images/11.jpg" class="img-responsive products">
                    <h4>Free Shipping</h4>
                    <button class="btn btn-md">Shop Now</button>
                </div>
                <div class="col-md-3 col-sm-3">
                    <img src="~/Content/Images/12.jpg" class="img-responsive products">
                    <h4>Free Shipping</h4>
                    <button class="btn btn-md">Shop Now</button>
                </div>
                <div class="col-md-3 col-sm-3">
                    <img src="~/Content/Images/13.jpg" class="img-responsive products">
                    <h4>Free Shipping</h4>
                    <button class="btn btn-md">Shop Now</button>
                </div>
                <div class="col-md-3 col-sm-3">
                    <img src="~/Content/Images/14.jpg" class="img-responsive products">
                    <h4>Free Shipping</h4>
                    <button class="btn btn-md">Shop Now</button>
                </div>
                <div class="col-md-3 col-sm-3">
                    <img src="~/Content/Images/15.jpg" class="img-responsive products">
                    <h4>Free Shipping</h4>
                    <button class="btn btn-md">Shop Now</button>
                </div>
                <div class="col-md-3 col-sm-3">
                    <img src="~/Content/Images/15.jpg" class="img-responsive products">
                    <h4>Free Shipping</h4>
                    <button class="btn btn-md">Shop Now</button>
                </div>
                <div class="col-md-3 col-sm-3">
                    <img src="~/Content/Images/16.jpg" class="img-responsive products">
                    <h4>Free Shipping</h4>
                    <button class="btn btn-md">Shop Now</button>
                </div>
            </div>
        </div>
    </section>
    <section class="cta">
        <div class="cta-content">
            <div class="container">
                <h2>Free Shipping With Your Order<br>Start Today</h2>
                <a href="contact.html" class="btn btn-primary">Lets Get Started</a>
            </div>
        </div>
    </section>
    <section id="social-contact" class="contact-area">
        <div class="container">
            <h2>We<i class="fa fa-heart"></i>New Friends!</h2>
            <ul class="list-inline list-social">
                <li class="social-twitter">
                    <a href="#"><i class="fa fa-twitter"></i></a>
                </li>
                <li class="social-facebook">
                    <a href="#"><i class="fa fa-facebook"></i></a>
                </li>
                <li class="social-google-plus">
                    <a href="#"><i class="fa fa-google-plus"></i></a>
                </li>
            </ul>
        </div>
    </section>
</main>
<!--  ======================= End Main Area ================================ -->
    