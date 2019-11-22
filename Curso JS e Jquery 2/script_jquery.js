$(document).ready(function () {
    $('#l').click(function () {
        $('#i').show();
        $('#ii').hide();
        $('#iii').hide();
        $('#iiii').hide();
    });

    $('#ll').click(function () {
        $('#i').hide();
        $('#ii').show();
        $('#iii').hide();
        $('#iiii').hide();
    });

    $('#lll').click(function () {
        $('#i').hide();
        $('#ii').hide();
        $('#iii').show();
        $('#iiii').hide();
    });

    $('#llll').click(function () {
        $('#i').hide();
        $('#ii').hide();
        $('#iii').hide();
        $('#iiii').show();
    });
});