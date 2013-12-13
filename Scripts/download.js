function validateForm() {

    if (!isEmpty("txtYearRep")) {
        return false;
    }

    if (!isEmpty("txtMonthRep")) {
        return false;
    }


    if (!isNumber("txtYearRep")) {
        return false;
    }

    if (!isNumber("txtMonthRep")) {
        return false;
    }

    if (!isEmpty("txtFileName")) {
        document.getElementById("lblMsg").value = "ファイル名を入力してください。";
        return false;
    } else {
        document.getElementById("lblMsg").value = "";
    }

    if (!confirmSubmit()) {
        return false;
    }

}
// ==============================
//  カーソル制御処理
// ==============================
function setFocus() {
    document.getElementById('txtYearRep').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('txtMonthRep').focus();
                document.getElementById('txtMonthRep').select();
                return false;
            }
        }

    document.getElementById('txtMonthRep').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('btnDownload').focus();
                document.getElementById('btnDownload').select();
                return false;
            }
        }
}


function setFileName() {

    var txtFileName = document.getElementById("txtFileName");
    var today = new Date();
    //年月日
    var YearMonthDay = String(today.getFullYear()) +
        String(covertDigit2(today.getMonth()+1)) +
        String(covertDigit2(today.getDate()));


    //時間分秒
    var HMS = String(covertDigit2(today.getHours())) +
              String(covertDigit2(today.getMinutes())) +
              String(covertDigit2(today.getSeconds()));

    var txtYearRep = document.getElementById("txtYearRep").value;
    var txtMonthRep = document.getElementById("txtMonthRep").value;
    var lblEra = document.getElementById("lblEra").innerHTML;

    //西暦に直す
    var SeirekiYearRep = warekiToSeireki(lblEra, txtYearRep);


    var txtFileName = String(SeirekiYearRep) + String(covertDigit2(txtMonthRep)) + "Jisseki" +
                              String(YearMonthDay) +
                              String(HMS) +
                              ".csv";

    document.getElementById("txtFileName").value = txtFileName;

}

function covertDigit2(param) {
    param=param*1
    if (param === 1 || param === 2 || param === 3 || param === 4
         || param === 5 || param === 6 || param === 7 || param === 8
           || param === 9   
        ) {
        return "0" + param;
    }
    return param;
}

function confirmSubmit() {
    if (confirm("ダウンロードしてもよろしいですか？")) {
        return true;
    } else {
        return false;
    }
}