var flag =
        {
            BigSize: false,
            MediumSmall: false,
            Average: false,
            ShibuFee: false,
            Kamotu7t: false,
            Kamotu6DP9_5t: false,
            Kamotu4DP9_3t: false,
            Kamotu2DP9_2DP5t: false,
            Over2001cc: false,
            To2000From1000cc: false,
            Over30: false,
            LessThan29: false

        };
function checkForm() {
    if (!isNumber("txtBigSize")) {

        flag.BigSize = false;
    } else {
        flag.BigSize = true;

    }

    if (!isNumber("txtMediumSmall")) {
        flag.MediumSmall = false;
    } else {
        flag.MediumSmall = true;
    }

    if (!isNumber("txtAverage")) {
        flag.Average = false;
    } else {
        flag.Average = true;
    }

    if (!isNumber("txtShibuFee")) {
        flag.ShibuFee = false;
    } else {
        flag.ShibuFee = true;
    }


    if (!isNumber("txtKamotu7t")) {
        flag.Kamotu7t = false;
    } else {
        flag.Kamotu7t = true;
    }


    if (!isNumber("txtKamotu6DP9_5t")) {
        flag.Kamotu6DP9_5t = false;
    } else {
        flag.Kamotu6DP9_5t = true;
    }

    if (!isNumber("txtKamotu4DP9_3t")) {
        flag.Kamotu4DP9_3t = false;
    } else {
        flag.Kamotu4DP9_3t = true;
    }

    if (!isNumber("txtKamotu2DP9_2DP5t")) {
        flag.Kamotu2DP9_2DP5t = false;
    } else {
        flag.Kamotu2DP9_2DP5t = true;
    }

    if (!isNumber("txtOver2001cc")) {
        flag.Over2001cc = false;
    } else {
        flag.Over2001cc = true;
    }

    if (!isNumber("txtTo2000From1000cc")) {
        flag.To2000From1000cc = false;
    } else {
        flag.To2000From1000cc = true;
    }

    if (!isNumber("txtOver30")) {
        flag.Over30 = false;
    } else {
        flag.Over30 = true;
    }

    if (!isNumber("txtLessThan29")) {
        flag.LessThan29 = false;
    } else {
        flag.LessThan29 = true;
    }

    if (!isNumber("txtMemberFee")) {
        flag.MemberFee = false;
    } else {
        flag.MemberFee = true;
    }
    if (
                flag.BigSize
                && flag.MediumSmall
                && flag.Average
                && flag.ShibuFee
                && flag.Kamotu7t
                && flag.Kamotu6DP9_5t
                && flag.Kamotu4DP9_3t
                && flag.Kamotu2DP9_2DP5t
                && flag.Over2001cc
                && flag.To2000From1000cc
                && flag.Over30
                && flag.LessThan29
                && flag.MemberFee
            ) {

    } else {
        return false;

    }


    if(confirm("更新してもよろしいですか？"))
    {
        return true;
    }else{
        return false;
    }

    

}

// ==============================
//  カーソル制御処理
// ==============================
function setFocus() {
    document.getElementById('txtBigSize').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtMediumSmall').focus();
                    document.getElementById('txtMediumSmall').select();
                    return false;
                }
            }

            document.getElementById('txtMediumSmall').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtAverage').focus();
                    document.getElementById('txtAverage').select();
                    return false;
                }
            }


    document.getElementById('txtAverage').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtShibuFee').focus();
                    document.getElementById('txtShibuFee').select();
                    return false;
                }
            }

    document.getElementById('txtShibuFee').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtKamotu7t').focus();
                    document.getElementById('txtKamotu7t').select();
                    return false;
                }
            }

    document.getElementById('txtKamotu7t').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtKamotu6DP9_5t').focus();
                    document.getElementById('txtKamotu6DP9_5t').select();
                    return false;
                }
            }

    document.getElementById('txtKamotu6DP9_5t').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtKamotu4DP9_3t').focus();
                    document.getElementById('txtKamotu4DP9_3t').select();
                    return false;
                }
            }

            document.getElementById('txtKamotu4DP9_3t').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtKamotu2DP9_2DP5t').focus();
                    document.getElementById('txtKamotu2DP9_2DP5t').select();
                    return false;
                }
            }

            document.getElementById('txtKamotu2DP9_2DP5t').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtOver2001cc').focus();
                    document.getElementById('txtOver2001cc').select();
                    return false;
                }
            }

            document.getElementById('txtOver2001cc').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtTo2000From1000cc').focus();
                    document.getElementById('txtTo2000From1000cc').select();
                    return false;
                }
            }

            document.getElementById('txtTo2000From1000cc').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtOver30').focus();
                    document.getElementById('txtOver30').select();
                    return false;
                }
            }

            document.getElementById('txtOver30').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtLessThan29').focus();
                    document.getElementById('txtLessThan29').select();
                    return false;
                }
            }

            document.getElementById('txtLessThan29').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtMemberFee').focus();
                    document.getElementById('txtMemberFee').select();
                    return false;
                }
            }

            document.getElementById('txtMemberFee').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('btnUpdate').focus();
                    document.getElementById('btnUpdate').select();
                    return false;
                }
            }

            document.getElementById('btnUpdate').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('btnReset').focus();
                    document.getElementById('btnReset').select();
                    return false;
                }
            }

}
