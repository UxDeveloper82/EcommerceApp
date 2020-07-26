<nav class="navbar navbar-expand-lg navbar-light">
    <div class="container">
        @Html.ActionLink("Ecommerce", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav"
                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
            <div class="mr-auto"></div>
            <ul class="navbar-nav">
                <li>@Html.ActionLink("About Products", "About", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li>@Html.ActionLink("Send Message", "Contact", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li>@Html.ActionLink("Projects", "Index", "Projects", New With {.area = ""}, New With {.class = "nav-link"})</li>
            </ul>
            @Html.Partial("_LoginPartial")
        </div>
    </div>
</nav>
    
