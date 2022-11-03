var currentDate = new Date();// mentions the current date.
var minimumTime = "10:00"; // mentions the start time.
var maximumTime = "17:00"; // mentions the start time.
var maximumTimeend = "18:00";
var minimumTimepicker;
// the following code sets the date range to 30 days from the current date.
var rangeDate = new Date(currentDate.getFullYear(), currentDate.getMonth(), currentDate.getDate() + 30);
$(function () {
    // declaration
    $("#datePicker").ejDatePicker({
        minDate: currentDate,// Default date as minDate.
    });


    $("#timeStart").ejTimePicker({
        timeFormat: 'HH:mm',
        interval: 30,
        minTime: '10:00',
        maxTime: '17:00',
        defaultTime: '10:00',
        startTime: '10:00',
        dynamic: false,
        dropdown: true,
        scrollbar: true,
        select: "selectedStartTime"
    });

    $('#timeEnd').ejTimePicker({
        timeFormat: 'HH:mm',
        interval: 30,
        minTime: '10:30',
        maxTime: '18:00',
        defaultTime: '10:00',
        startTime: '10:00',
        dynamic: false,
        dropdown: true,
        scrollbar: true
    });
});

function selectedStartTime(sender) {
    var currentStartTime = document.getElementById("timeStart").value;
    var endTime = document.getElementById("timeEnd");

    var currentHour = currentStartTime[0] + currentStartTime[1];
    var currentMinutes = currentStartTime[3] + currentStartTime[4];

    var date = new Date();

    var newDate = new Date(date.getYear(), date.getMonth(), date.getDay(), currentHour, currentMinutes);
    newDate.setMinutes(newDate.getMinutes() + 30);

    endTime.value = newDate.getHours() + ":" + (newDate.getMinutes() < 10 ? '0' : '') + newDate.getMinutes();
}



/**datapiker */
$(document).ready(function () {
    var container = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
    var options = {
        format: 'dd/mm/yyyy',
        startDate: '22/09/2022',
        endDate: '31/12/2022',
        container: container,
        todayHighlight: true,
        autoclose: true,
        todayBtn: "linked",
        daysOfWeekDisabled: "0,6",
        calendarWeeks: true
    };
})




