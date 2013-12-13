//=============================
// 先頭の空白を削除
//=============================
String.prototype.ltrim = function () {
    return this.replace(/^\s+/, "");
}
//=============================
// 末尾の空白を削除
//=============================
String.prototype.rtrim = function () {
    return this.replace(/\s+$/, "");
}
//=============================
// 先頭および末尾の空白を削除
//=============================
String.prototype.trim = function () {
    return this.replace(/^\s+|\s+$/g, "");
}
//=============================
// 先頭および末尾の、全角空白、半角空白、タブ、を削除
//=============================
String.prototype.jtrim = function () {
    return unescape(escape(this).replace(/^(%u3000|%20|%09)+|(%u3000|%20|%09)+$/g, ""));
}

//=============================
//数値のチェック
//=============================
function isNumber(id) {
    //数値かどうかのチェック
    var obj = document.getElementById(id);

    //エラーの時は背景色を変える
    if (isNaN(obj.value)) {
        //document.getElementById(id).style.backgroundColor = "Pink";
        //document.getElementById(id).focus();
        //ブランクもエラーとなる
        isError(id);
        return false;
    } else {
        //document.getElementById(id).style.backgroundColor = "White";
        //-1とかも数値扱い
        isOk(id);
        return true;

    }
}



//=============================
//必須のチェック
//=============================
function isEmpty(id) {
    //数値かどうかのチェック
    var obj = document.getElementById(id);

    //エラーの時は背景色を変える
    if (obj.value == "") {

    //    document.getElementById(id).style.backgroundColor = "Pink";
        //    document.getElementById(id).focus();
        isError(id);
        return false;
    } else {
        //document.getElementById(id).style.backgroundColor = "White";
        isOk(id);
        return true;
    }
}

//=============================
//エラー時に色を変える
//=============================
function isError(id) {
    document.getElementById(id).style.backgroundColor = "Pink";
    document.getElementById(id).focus();
    document.getElementById(id).select();
}

function isOk(id) {
    document.getElementById(id).style.backgroundColor = "White";

}

//=============================
//メッセージを表示する
//=============================
function showMsg(id, message) 
{
    var obj = document.getElementById(id);
    obj.style.backgroundColor = "Pink";
    obj.innerHTML = message;
}
function eraseMsg(id) {
    var obj = document.getElementById(id);
    obj.style.backgroundColor = "White";
    obj.innerHTML = "";
}


//和暦を西暦に変換(igarashi)
function warekiToSeireki(Gengo, y) {
    y = parseInt(y, 10);
    var seireki;

    switch (Gengo) {
        case "平成":
            if ((y > 0)) {
                seireki = 1988 + y; //　平成
            }
            break;
        case "昭和":
            if ((y > 0) && (y < 65)) {
                seireki = 1925 + y;
            }
            break;

        case "大正":
            if ((y > 0) && (y < 16)) {
                seireki = 1911 + y;
            }
            break;

        case "明治":
            if ((y > 0) && (y < 46)) {
                seireki = 1867 + y;
            }
            break;
    }

    return seireki;
}

