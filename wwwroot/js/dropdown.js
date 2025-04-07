
$(document).ready(function () {

    var $PageElems = {
        dropdown: $("#Dropdown")
    };

    if ($PageElems.dropdown.length) {
        $PageElems.dropdown.select2({
            placeholder: 'Search by FirstName',
            allowClear: true,
            minimumInputLength: 1,
            ajax: {
                url: '/Home/SearchUsers',
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    return {
                        q: params.term
                    };
                },
                processResults: function (data) {
                    return {
                        results: data
                    };
                },
                cache: true
            }
        });
    }
    });
