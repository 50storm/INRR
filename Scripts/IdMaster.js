// ==============================
//  カーソル制御処理
// ==============================
function setFocus() {
    document.getElementById('txtCOCODE').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtUID').focus();
                    document.getElementById('txtUID').select();
                    return false;
                }
            }

    document.getElementById('txtUID').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtCONAME').focus();
                    document.getElementById('txtCONAME').select();
                    return false;
                }
            }


    document.getElementById('txtCONAME').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtshort_CONAME').focus();
                    document.getElementById('txtshort_CONAME').select();
                    return false;
                }
            }

    document.getElementById('txtshort_CONAME').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtRepName').focus();
                    document.getElementById('txtRepName').select();
                    return false;
                }
            }

    document.getElementById('txtRepName').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtPostalCode').focus();
                    document.getElementById('txtPostalCode').select();
                    return false;
                }
            }

    document.getElementById('txtPostalCode').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtAddress').focus();
                    document.getElementById('txtAddress').select();
                    return false;
                }
            }

    document.getElementById('txtAddress').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtTel').focus();
                    document.getElementById('txtTel').select();
                    return false;
                }
            }

    document.getElementById('txtTel').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtPassword').focus();
                    document.getElementById('txtPassword').select();
                    return false;
                }
            }

    document.getElementById('txtPassword').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtMember').focus();
                    document.getElementById('txtMember').select();
                    return false;
                }
            }

    document.getElementById('txtMember').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtMemberType').focus();
                    document.getElementById('txtMemberType').select();
                    return false;
                }
            }

    document.getElementById('txtMemberType').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtPosition').focus();
                    document.getElementById('txtPosition').select();
                    return false;
                }
            }

    document.getElementById('txtPosition').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtisCanceled').focus();
                    document.getElementById('txtisCanceled').select();
                    return false;
                }
            }

    document.getElementById('txtisCanceled').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('btnInsert').focus();
                    document.getElementById('btnInsert').select();
                    return false;
                }
            }

    document.getElementById('btnInsert').onkeydown
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
                    document.getElementById('btnDelete').focus();
                    document.getElementById('btnDelete').select();
                    return false;
                }
            }

    document.getElementById('btnDelete').onkeydown
            = function () {
                if (event.keyCode == 13) {
                    document.getElementById('txtCOCODE').focus();
                    document.getElementById('txtCOCODE').select();
                    return false;

                }
            }
}


function validateFrom() {
    /*必須チェック*/
    //会員コード
    if (!isEmpty("txtCOCODE")) {
        isError("txtCOCODE");
        showMsg("lblMsg", "会員コードは必須です");
        return false;
    } else {
        eraseMsg("lblMsg");
    }
    //ログインID
    if (!isEmpty("txtUID")) {
        isError("txtUID");
        showMsg("lblMsg", "ログインIDは必須です");
        return false;
    } else {
        eraseMsg("lblMsg");
    }
    //会員フラグ
    if (!isEmpty("txtMember")) {
        isError("txtMember");
        showMsg("lblMsg", "会員フラグは必須です");
        return false;
    } else {
        eraseMsg("lblMsg");
    }
    //会員種別
    if (!isEmpty("txtMemberType")) {
        isError("txtMemberType");
        showMsg("lblMsg", "会員種別は必須です");
        return false;
    } else {
        eraseMsg("lblMsg");
    }
    //退会フラグ
    if (!isEmpty("txtisCanceled")) {

        showMsg("lblMsg", "退会フラグは必須です");
        return false;
    } else {
        eraseMsg("lblMsg");
    }

    /*数値チェック*/
    //会員コード
    if (!isNumber("txtCOCODE")) {
        document.getElementById("txtCOCODE").focus();
        showMsg("lblMsg", "会員コードは数値のみ入力可能です");
        return false;
    } else {
        eraseMsg("lblMsg");
    }

    //ログインID
    if (!isNumber("txtUID")) {
        document.getElementById("txtUID").focus();
        showMsg("lblMsg", "ログインIDは数値のみ入力可能です");
        return false;
    } else {
        eraseMsg("lblMsg");
    }

    //会員フラグ
    var txtMember = document.getElementById("txtMember");
    if (parseInt(txtMember.value, 10) !== 0
               &&
                parseInt(txtMember.value, 10) !== 1
               ) {
        document.getElementById("txtMember").focus();
        isError("txtMember");
        return false;
    } else {
        isOk("txtMember");
    }

    //会員種別
    if (!isNumber("txtMemberType")) {
        document.getElementById("txtMemberType").focus();
        return false;
    }

    var txtMemberType = document.getElementById("txtMemberType");
    if (parseInt(txtMemberType.value, 10) !== 0
               &&
                parseInt(txtMemberType.value, 10) !== 1
               ) {
        document.getElementById("txtMemberType").focus();
        isError("txtMemberType");
        return false;
    } else {
        isOk("txtMemberType");
    }

    //ポジション
    if (!isNumber("txtPosition")) {
        document.getElementById("txtPosition").focus();
        return false;
    }

    //退会フラグ
    if (!isNumber("txtisCanceled")) {
        document.getElementById("txtisCanceled").focus();
        return false;
    }
    var txtisCanceled = document.getElementById("txtisCanceled");
    if (parseInt(txtisCanceled.value, 10) !== 0
               &&
                parseInt(txtisCanceled.value, 10) !== 1
               ) {
        document.getElementById("txtisCanceled").focus();
        isError("txtisCanceled");
        return false;
    } else {
        isOk("txtisCanceled");
    }

    return true;

}

//登録確認
function confirmRegister() {

    if (!validateFrom()) {
        return false;
    }

    if (!confirm("登録しますか？")) {
        return false;
    }
}

//更新登録
function confirmUpdate() {

    if (!validateFrom()) {
        return false;
    }

    if (!confirm("更新しますか？")) {
        return false;
    }
}


//削除確認
function confirmDeletion() {
    /*必須チェック*/
    //会員コード
    if (!isEmpty("txtCOCODE")) {
        isError("txtCOCODE");
        showMsg("lblMsg", "会員コードは必須です");
        return false;
    } else {
        eraseMsg("lblMsg");
    }

    alert("会員マスターから削除すると、新車新規登録台数のデータも削除されます。");

    alert("会員が退会の場合は、退会フラグを「1：退会済み」にしてください");
     

    if (!confirm("本当に削除しますか？")) {
        return false;
    }
}