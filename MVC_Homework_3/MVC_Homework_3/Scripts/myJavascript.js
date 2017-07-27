
$(".subscribeButton").click(
    function () {
        if ($(this).text() == 'Subscribed') {
            $(this).text('Unsubscribed');
            alert("you have unsubscribed");
        } else {
            $(this).text('Subscribed');
            alert("you have subscribed");
        }


    });