
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetData",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Please Select a Car</option>';
            for (var i = 0; i < data.vehicles.length; i++) {
                s += '<option value="' + data.vehicles[i].vechiclecapacity + '">' + data.vehicles[i].vechicletype + '</option>';
            }
            $("#selectvehicle").html(s);
        }
    });
    $('#txtcapacity').on('input', function () {
        calculate();
    });
    $('#selectOccupancy').on('change', function () {
        calculate();
        $('.checkvalue').each(function (index, value) {
            $(value).attr('checked', false);
        });
        var Occupancy = $('#txtoccupancy').val();
        var tempoccupancy = 0.0;
        //element.find('tbody').children("tr").each(function () {
        tr = $('#ordertable').children('tbody');
        $("#ordertable tbody tr").each(function (index, value) {
            tempoccupancy += parseFloat($(value).find('td.ordertd').html());
            if (tempoccupancy <= Occupancy) {
                $(value).find('td.EligibleforTrip').find('.checkvalue').attr('checked', true);
            }
            else {
                return;
            }
        });

    });
});
function getValue() {
    var myVal = $("#selectvehicle").val();
    $("#txtcapacity").val(myVal);
}

function calculate() {
        var pPos = parseInt($('#txtcapacity').val());
        var pEarned = parseInt($('#selectOccupancy').val());
        var perc = "";
        if (isNaN(pPos) || isNaN(pEarned)) {
            perc = " ";
        } else {
            perc = (pEarned / 100) * pPos;
        }
        $('#txtoccupancy').val(perc);
    }







   



   