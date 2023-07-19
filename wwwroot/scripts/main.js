$(function () {
    $("#searchInput").autocomplete(
        {
            source: function (request, response) {
                $.ajax(
                    {
                        url: "/api/Details/GetUserDetail",
                        data: { "search": request.term },
                        type: "GET",
                        success: function (data) {
                            response($.map(data, function (item) {
                                return item;
                            }));
                        },
                        error: function (response) {
                            alert(response.responseText);
                        },
                        failure: function (response) {
                            alert(response.responseText);
                        }
                    });
            },
            select: function (e, i) {
                $("#hiddenSearch").val(i.item.val);
            },
            minLength: 1

        })

});