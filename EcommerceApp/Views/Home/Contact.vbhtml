<section id="contact" class="contact">
    <div class="container">
        <div class="row">
            <h2>Contact-Us</h2>
            <hr>
        </div>
        <div class="row-form">
            <form id="form-area">
                <div class="form-group">
                    <label form="name">Name</label>
                    <input id="name" type="text" placeholder="Name" class="form-control">
                </div>
                <div class="form-group">
                    <label>Email</label>
                    <input id="email" type="text" placeholder="Email" class="form-control">
                </div>
                <div class="form-group">
                    <label>Message</label>
                    <textarea id="message" type="message" name="message" class="form-control" rows="5"></textarea>
                </div>
                <input type="submit" class="btn btn-primary" value="Send Message">
            </form>
            <table class="table mt-5">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Message</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody id="message-list"></tbody>
            </table>
        </div>
    </div>
</section>
