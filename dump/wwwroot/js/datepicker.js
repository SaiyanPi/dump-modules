$(function () {
    $("#txtDate").datepicker({
        changeMonth: true,
        changeYear: true,
       /* showOn: 'button',*/
        buttonImageOnly: true,
        /*buttonImage: 'images/cal.jpg',*/
        dateFormat: 'dd/mm/yy',
        yearRange: '1900:+0',
        onSelect: function (dateString, txtDate) {
            ValidateDOB(dateString);
        }
    });
});
function ValidateDOB(dateString) {
    var lblError = $("#lblError");
    var parts = dateString.split("/");
    var dtDOB = new Date(parts[1] + "/" + parts[0] + "/" + parts[2]);
    var dtCurrent = new Date();
    lblError.html("Eligibility 18 years ONLY.")
    if (dtCurrent.getFullYear() - dtDOB.getFullYear() < 18) {
        return false;
    }

    if (dtCurrent.getFullYear() - dtDOB.getFullYear() == 18) {
 
        //CD: 11/06/2018 and DB: 15/07/2000. Will turned 18 on 15/07/2018.
        if (dtCurrent.getMonth() < dtDOB.getMonth()) {
            return false;
        }
        if (dtCurrent.getMonth() == dtDOB.getMonth()) {
            //CD: 11/06/2018 and DB: 15/06/2000. Will turned 18 on 15/06/2018.
            if (dtCurrent.getDate() < dtDOB.getDate()) {
                return false;
            }
        }
    }
    lblError.html("");
    return true;
}



$(function () {
    $("#txtDate3").datepicker({
        changeMonth: true,
        changeYear: true,
        /* showOn: 'button',*/
        buttonImageOnly: true,
        /*buttonImage: 'images/cal.jpg',*/
        dateFormat: 'dd/mm/yy',
        yearRange: '1900:+0',
        onSelect: function (dateString3, txtDate) {
            ValidateDOB1(dateString3);
        }
    });
});
function ValidateDOB1(dateString3) {
    var lblError3 = $("#lblError3");
    var parts3 = dateString3.split("/");
    var dtDOB3 = new Date(parts3[1] + "/" + parts3[0] + "/" + parts3[2]);
    var dtCurrent3 = new Date();
    lblError3.html("Eligibility 18 years ONLY.")
    if (dtCurrent3.getFullYear() - dtDOB3.getFullYear() < 18) {
        return false;
    }

    if (dtCurrent3.getFullYear() - dtDOB3.getFullYear() == 18) {

        //CD: 11/06/2018 and DB: 15/07/2000. Will turned 18 on 15/07/2018.
        if (dtCurrent3.getMonth() < dtDOB3.getMonth()) {
            return false;
        }
        if (dtCurrent3.getMonth() == dtDOB3.getMonth()) {
            //CD: 11/06/2018 and DB: 15/06/2000. Will turned 18 on 15/06/2018.
            if (dtCurrent3.getDate() < dtDOB3.getDate()) {
                return false;
            }
        }
    }
    lblError3.html("");
    return true;
}