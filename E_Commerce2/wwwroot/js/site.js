function AddToCart(productId) {
    $.ajax({
        url: "https://localhost:7242/Cart/AddToCart/" + productId,
        type: "POST",
        dataType: "json",
        data: {},
        success: function (data) {
            //Process Return Data
            toastr.success('Item added to cart successfully.', 'Success', {
                timeOut: 3000, // Time in milliseconds to display the notification
                progressBar: true, // Show a progress bar
                closeButton: true, // Show a close button
                positionClass: 'toast-top-right', // Position on the screen (e.g., top-left, top-right, bottom-left, bottom-right)
            });

        },
        error: function (xhr, status, error) {
            toastr.error('Item could not be added to card.', 'Error', {
                timeOut: 3000, // Time in milliseconds to display the notification
                progressBar: true, // Show a progress bar
                closeButton: true, // Show a close button
                positionClass: 'toast-top-right', // Position on the screen (e.g., top-left, top-right, bottom-left, bottom-right)
            });

        }
    })
}