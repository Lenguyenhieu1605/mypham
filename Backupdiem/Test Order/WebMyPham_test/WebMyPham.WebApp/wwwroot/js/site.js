var SiteController = function () {
    this.initialize = function () {
        registerEvents();
        loadCart();
    }

    function loadCart() {
        $.ajax({
            type: "GET",
            url: 'Cart/GetListItems',
            success: function (res) {
                $('#lbl_number_items_header').text(res.length);
            }
        });

    }

    function registerEvents() {
        $('body').on('click', '.btn-add-cart', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            $.ajax({
                type: "POST",
                url: 'Cart/AddToCart',
                data: {
                    id: id
                },
                success: function (res) {
                    $('#lbl_number_items_header').text(res.length);
                },
                error: function (err) {
                    console.log(err);
                }
            });
        });
    }
}

function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}