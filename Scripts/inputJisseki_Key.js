// ==============================
//  カーソル制御処理
// ==============================
function setFocus() {
    //上部
    document.getElementById('txtYearRep0').onkeydown
   = function () {
       if (event.keyCode == 13) {
           document.getElementById('txtMonthRep0').focus();
           document.getElementById('txtMonthRep0').select();
           return false;
       }
   }

    document.getElementById('txtMonthRep0').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtYear').focus();
	        document.getElementById('txtYear').select();
	        return false;
	    }
	}
    document.getElementById('txtYear').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMonth').focus();
	        document.getElementById('txtMonth').select();
	        return false;
	    }
	}

    document.getElementById('txtMonth').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtDay').focus();
	        document.getElementById('txtDay').select();
	        return false;
	    }

	}

    document.getElementById('txtDay').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSyamei').focus();
	        document.getElementById('txtSyamei').select();
	        return false;
	    }

	}

    document.getElementById('txtSyamei').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }

	}

    document.getElementById('txtTantou').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_Kamotu1').focus();
	        document.getElementById('txtMito_Kamotu1').select();
	        return false;
	    }

	}

    //Mito
    document.getElementById('txtMito_Kamotu1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_Kamotu2').focus();
	        document.getElementById('txtMito_Kamotu2').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_Kamotu2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_Kamotu3').focus();
	        document.getElementById('txtMito_Kamotu3').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_Kamotu3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_Kamotu4').focus();
	        document.getElementById('txtMito_Kamotu4').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_Kamotu4').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_Bus1').focus();
	        document.getElementById('txtMito_Bus1').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_Bus1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_Bus2').focus();
	        document.getElementById('txtMito_Bus2').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_Bus2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_JK_J1').focus();
	        document.getElementById('txtMito_JK_J1').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_JK_J1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_JK_K1').focus();
	        document.getElementById('txtMito_JK_K1').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_JK_K1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_JK_J2').focus();
	        document.getElementById('txtMito_JK_J2').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_JK_J2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_JK_K2').focus();
	        document.getElementById('txtMito_JK_K2').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_JK_K2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_JK_J3').focus();
	        document.getElementById('txtMito_JK_J3').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_JK_J3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtMito_JK_K3').focus();
	        document.getElementById('txtMito_JK_K3').select();
	        return false;
	    }
	}

    document.getElementById('txtMito_JK_K3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_Kamotu1').focus();
	        document.getElementById('txtTuchiura_Kamotu1').select();
	        return false;
	    }
	}
    document.getElementById('txtMito_SubTotal1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtMito_Total1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

    //Tuchiura
    document.getElementById('txtTuchiura_Kamotu1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_Kamotu2').focus();
	        document.getElementById('txtTuchiura_Kamotu2').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_Kamotu2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_Kamotu3').focus();
	        document.getElementById('txtTuchiura_Kamotu3').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_Kamotu3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_Kamotu4').focus();
	        document.getElementById('txtTuchiura_Kamotu4').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_Kamotu4').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_Bus1').focus();
	        document.getElementById('txtTuchiura_Bus1').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_Bus1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_Bus2').focus();
	        document.getElementById('txtTuchiura_Bus2').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_Bus2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_JK_J1').focus();
	        document.getElementById('txtTuchiura_JK_J1').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_JK_J1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_JK_K1').focus();
	        document.getElementById('txtTuchiura_JK_K1').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_JK_K1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_JK_J2').focus();
	        document.getElementById('txtTuchiura_JK_J2').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_JK_J2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_JK_K2').focus();
	        document.getElementById('txtTuchiura_JK_K2').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_JK_K2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_JK_J3').focus();
	        document.getElementById('txtTuchiura_JK_J3').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_JK_J3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTuchiura_JK_K3').focus();
	        document.getElementById('txtTuchiura_JK_K3').select();
	        return false;
	    }
	}

    document.getElementById('txtTuchiura_JK_K3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_Kamotu1').focus();
	        document.getElementById('txtTukuba_Kamotu1').select();
	        return false;
	    }
	}
	document.getElementById('txtTuchiura_SubTotal1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtTuchiura_Total1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

    //Tukuba
    document.getElementById('txtTukuba_Kamotu1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_Kamotu2').focus();
	        document.getElementById('txtTukuba_Kamotu2').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_Kamotu2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_Kamotu3').focus();
	        document.getElementById('txtTukuba_Kamotu3').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_Kamotu3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_Kamotu4').focus();
	        document.getElementById('txtTukuba_Kamotu4').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_Kamotu4').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_Bus1').focus();
	        document.getElementById('txtTukuba_Bus1').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_Bus1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_Bus2').focus();
	        document.getElementById('txtTukuba_Bus2').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_Bus2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_JK_J1').focus();
	        document.getElementById('txtTukuba_JK_J1').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_JK_J1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_JK_K1').focus();
	        document.getElementById('txtTukuba_JK_K1').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_JK_K1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_JK_J2').focus();
	        document.getElementById('txtTukuba_JK_J2').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_JK_J2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_JK_K2').focus();
	        document.getElementById('txtTukuba_JK_K2').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_JK_K2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_JK_J3').focus();
	        document.getElementById('txtTukuba_JK_J3').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_JK_J3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTukuba_JK_K3').focus();
	        document.getElementById('txtTukuba_JK_K3').select();
	        return false;
	    }
	}

    document.getElementById('txtTukuba_JK_K3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_Kamotu1').focus();
	        document.getElementById('txtSonota_Kamotu1').select();
	        return false;
	    }
	}
	document.getElementById('txtTukuba_SubTotal1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtTukuba_Total1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}


    //その他
    document.getElementById('txtSonota_Kamotu1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_Kamotu2').focus();
	        document.getElementById('txtSonota_Kamotu2').select();
	        return false;
	    }
	}

    document.getElementById('txtSonota_Kamotu2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_Kamotu3').focus();
	        document.getElementById('txtSonota_Kamotu3').select();
	        return false;
	    }
	}

    document.getElementById('txtSonota_Kamotu3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_Kamotu4').focus();
	        document.getElementById('txtSonota_Kamotu4').select();
	        return false;
	    }
	}

    document.getElementById('txtSonota_Kamotu4').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_Bus1').focus();
	        document.getElementById('txtSonota_Bus1').select();
	        return false;
	    }
	}

    document.getElementById('txtSonota_Bus1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_Bus2').focus();
	        document.getElementById('txtSonota_Bus2').select();
	        return false;
	    }
	}

    document.getElementById('txtSonota_Bus2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_JK_J1').focus();
	        document.getElementById('txtSonota_JK_J1').select();
	        return false;
	    }
	}

    document.getElementById('txtSonota_JK_J1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_JK_K1').focus();
	        document.getElementById('txtSonota_JK_K1').select();
	        return false;
	    }
	}

    document.getElementById('txtSonota_JK_K1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_JK_J2').focus();
	        document.getElementById('txtSonota_JK_J2').select();
	        return false;
	    }
	}

    document.getElementById('txtSonota_JK_J2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_JK_K2').focus();
	        document.getElementById('txtSonota_JK_K2').select();
	        return false;
	    }
	}

    document.getElementById('txtSonota_JK_K2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_JK_J3').focus();
	        document.getElementById('txtSonota_JK_J3').select();
	        return false;
	    }
	}


    document.getElementById('txtSonota_JK_J3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtSonota_JK_K3').focus();
	        document.getElementById('txtSonota_JK_K3').select();
	        return false;
	    }
	}


    document.getElementById('txtSonota_JK_K3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('btnSubmit').focus();
	        document.getElementById('btnSubmit').select();
	        return false;
	    }
	}
	document.getElementById('txtSonota_SubTotal1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtSonota_Total1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}


    //合計
	document.getElementById('txtGoukei_Kamotu1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtGoukei_Kamotu2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtGoukei_Kamotu3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtGoukei_Kamotu4').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtGoukei_Bus1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtGoukei_Bus2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtGoukei_JK_J1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}
	document.getElementById('txtGoukei_JK_K1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtGoukei_JK_J2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}
	document.getElementById('txtGoukei_JK_K2').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}

	document.getElementById('txtGoukei_JK_J3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}
	document.getElementById('txtGoukei_JK_K3').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}
	document.getElementById('txtGoukei_SubTotal1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}
	document.getElementById('txtGoukei_Total1').onkeydown
	= function () {
	    if (event.keyCode == 13) {
	        document.getElementById('txtTantou').focus();
	        document.getElementById('txtTantou').select();
	        return false;
	    }
	}
}
