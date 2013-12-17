﻿
//=============================
//check Header
//=============================
var flagHeader = 
{
	txtYear:false,
	txtMonth:false,
	txtTantou: false,
    txtSyamei:false,
    txtYearRep0:false,
    txtMonthRep0: false
    
};



function headerIsMust() 
{

    //必須チェック
    if (isEmpty("txtYear")) {
        flagHeader.txtYear = true;
    }
    else {
        flagHeader.txtYear = false;
    }

    if (isEmpty("txtMonth")) {
        flagHeader.txtMonth = true;

    } else {
        flagHeader.txtMonth = false;

    }

    if (isEmpty("txtDay")) {
        flagHeader.txtDay = true;
    } else {
        flagHeader.txtDay = false;

    }

    if (isEmpty("txtSyamei")) {
        flagHeader.txtSyamei = true;
    } else {
        flagHeader.txtSyamei = false;

    }

    if (isEmpty("txtTantou")) {
        flagHeader.txtTantou = true;
    } else {
        flagHeader.txtTantou = false;
    }

    if (isEmpty("txtYearRep0")) {
        flagHeader.txtYearRep0 = true;
    } else {
        flagHeader.txtYearRep0 = false;

    }

    if (isEmpty("txtMonthRep0")) {
        flagHeader.txtMonthRep0 = true;
    } else {
        flagHeader.txtMonthRep0 = false;

    }

    if (   flagHeader.txtYear     && flagHeader.txtMonth && flagHeader.txtDay
        && flagHeader.txtSyamei   && flagHeader.txtTantou
        && flagHeader.txtYearRep0 && flagHeader.txtMonthRep0
            ) {
     
    } else {
        return false;
    }

    return true;
}

function headerNumberIsValid() {
    //数字チェック    
    if (isNumber("txtYear")) {
        flagHeader.txtYear = true;
    } else {
        flagHeader.txtYear = false;
    }

    if (isNumber("txtMonth")) {
        flagHeader.txtMonth = true;
    } else {
        flagHeader.txtMonth = false;
    }

    if (isNumber("txtDay")) {
        flagHeader.txtDay = true;
    } else {
        flagHeader.txtDay = false;
    }

    if (isNumber("txtYearRep0")) {
        flagHeader.txtYearRep0 = true;
    } else {
        flagHeader.txtYearRep0 = false;
    }

    if (isNumber("txtMonthRep0")) {
        flagHeader.txtMonthRep0 = true;
    } else {
        flagHeader.txtMonthRep0 = false;
    }
    
    if (flagHeader.txtYear && flagHeader.txtMonth && flagHeader.txtDay
        && flagHeader.txtYearRep0 && flagHeader.txtMonthRep0
        ) {
    
    } else {
        return false;
    }

    return true;

}


function headerMonthRangeIsValid() {

    //月
    if (document.getElementById("txtMonthRep0").value * 1 > 12 || document.getElementById("txtMonthRep0").value * 1 < 1) {
        flagHeader.txtMonthRep0 = false;

    }
    else {
        flagHeader.txtMonthRep0 = true;
    }


    if (flagHeader.txtMonthRep0) {

    } else { 
        return false;
    }

    return true;
}


function checkFormsHeader() {

    //必須チェック
    if (!headerIsMust()) {
        return false;
    }

    //数字チェック
    if (!headerNumberIsValid()) {
        return false;
    }

    //範囲チェック
    if (!headerMonthRangeIsValid()) {
        return false;
    }

}

//=============================
//check Mito
//=============================
var flgMito = 
{
	txtMito_Kamotu1:false,
	txtMito_Kamotu2:false,
	txtMito_Kamotu3:false,
	txtMito_Kamotu4:false,
	txtMito_Bus1:false,
	txtMito_Bus2:false,
	txtMito_JK_J1:false,
	txtMito_JK_K1:false,
	txtMito_JK_J2:false,
	txtMito_JK_K2:false,
	txtMito_JK_J3:false,
	txtMito_JK_K3:false,
	txtMito_SubTotal1:false,
	txtMito_Total1:false
};

function checkMito() {

	if (isNumber("txtMito_Kamotu1")) {
	    flgMito.txtMito_Kamotu1 = true;
	}else{
	    flgMito.txtMito_Kamotu1 = false;
	}
	if (isNumber("txtMito_Kamotu2")) {
	    flgMito.txtMito_Kamotu2 = true;
	} else {
        flgMito.txtMito_Kamotu2 = false;
        
    }
    if (isNumber("txtMito_Kamotu3")) {
        flgMito.txtMito_Kamotu3 = true;
    } else {
        flgMito.txtMito_Kamotu3 = false;
    }
	if (isNumber("txtMito_Kamotu4")) {
	    flgMito.txtMito_Kamotu4 = true;
    } else {
	    flgMito.txtMito_Kamotu4 = false;
    }      
 	if (isNumber("txtMito_Bus1")) {
        flgMito.txtMito_Bus1 = true;
    } else {
        flgMito.txtMito_Bus1 = false;
    }
 	if (isNumber("txtMito_Bus2")) {
        flgMito.txtMito_Bus2 = true;
    } else {
        flgMito.txtMito_Bus2 = false;
    }
	if (isNumber("txtMito_JK_J1")) {
	    flgMito.txtMito_JK_J1 = true;
    } else {
	    flgMito.txtMito_JK_J1 = false;
    }
	
	if (isNumber("txtMito_JK_K1")) {
	    flgMito.txtMito_JK_K1 = true;
    } else {
        flgMito.txtMito_JK_K1 = false;	
    }
	if (isNumber("txtMito_JK_J2")) {
        flgMito.txtMito_JK_J2 = true;    
    } else {
        flgMito.txtMito_JK_J2 = false;
        
    }
	
	if (isNumber("txtMito_JK_K2")) {
        flgMito.txtMito_JK_K2 = true;
	    
    } else {
        flgMito.txtMito_JK_K2 = false;   
    }
           
    if (isNumber("txtMito_JK_J3")) {
        flgMito.txtMito_JK_J3 = true;
        
    } else {
        flgMito.txtMito_JK_J3 = false;
        
    }
    
	if (isNumber("txtMito_JK_K3")) {
        flgMito.txtMito_JK_K3 = true;
	    
    } else {
        flgMito.txtMito_JK_K3 = false;
    
    }
	
	if (isNumber("txtMito_SubTotal1")) {
	    flgMito.txtMito_SubTotal1 = true;
    } else {
	    flgMito.txtMito_SubTotal1 = false;
    }
	
	if (isNumber("txtMito_Total1")) {
	    flgMito.txtMito_Total1 = true;
	} else {
        flgMito.txtMito_Total1 = false;
    
    }
	
	if(flgMito.txtMito_Kamotu1 && flgMito.txtMito_Kamotu2 && flgMito.txtMito_Kamotu3 &&
		flgMito.txtMito_Kamotu4 && flgMito.txtMito_Bus1   && flgMito.txtMito_Bus2  &&
		flgMito.txtMito_JK_J1 && flgMito.txtMito_JK_K1 && flgMito.txtMito_JK_J2 &&
		flgMito.txtMito_JK_K2 && flgMito.txtMito_JK_J3 && flgMito.txtMito_JK_K3 &&
		flgMito.txtMito_SubTotal1  && flgMito.txtMito_Total1)
	{
		return true;
	
	}else{
		return false;
	}
	
}

//=============================
//check Tuchiura
//=============================
var flgTuchiura = 
{
	txtTuchiura_Kamotu1:false,
	txtTuchiura_Kamotu2:false,
	txtTuchiura_Kamotu3:false,
	txtTuchiura_Kamotu4:false,
	txtTuchiura_Bus1:false,
	txtTuchiura_Bus2:false,
	txtTuchiura_JK_J1:false,
	txtTuchiura_JK_K1:false,
	txtTuchiura_JK_J2:false,
	txtTuchiura_JK_K2:false,
	txtTuchiura_JK_J3:false,
	txtTuchiura_JK_K3:false,
	txtTuchiura_SubTotal1:false,
	txtTuchiura_Total1:false
};

function checkTuchiura(){
	if (isNumber("txtTuchiura_Kamotu1")) {
		flgTuchiura.txtTuchiura_Kamotu1 = true;
	}else{
		flgTuchiura.txtTuchiura_Kamotu1 = false;
	}
	if (isNumber("txtTuchiura_Kamotu2")) {
		flgTuchiura.txtTuchiura_Kamotu2 = true;
    } else {
		flgTuchiura.txtTuchiura_Kamotu2 = false;
    }
    if (isNumber("txtTuchiura_Kamotu3")) {
		flgTuchiura.txtTuchiura_Kamotu3 = true;
    } else {
		flgTuchiura.txtTuchiura_Kamotu3 = false;
    }
	if (isNumber("txtTuchiura_Kamotu4")) {
		flgTuchiura.txtTuchiura_Kamotu4 = true;
    } else {
		flgTuchiura.txtTuchiura_Kamotu4 = false;
    }      
 	if (isNumber("txtTuchiura_Bus1")) {
		flgTuchiura.txtTuchiura_Bus1 = true;
    } else {
		flgTuchiura.txtTuchiura_Bus1 = false;
    }
 	if (isNumber("txtTuchiura_Bus2")) {
		flgTuchiura.txtTuchiura_Bus2 = true;
    } else {
		flgTuchiura.txtTuchiura_Bus2 = false;
    }
	if (isNumber("txtTuchiura_JK_J1")) {
		flgTuchiura.txtTuchiura_JK_J1 = true;
    } else {
		flgTuchiura.txtTuchiura_JK_J1 = false;
    }
	
	if (isNumber("txtTuchiura_JK_K1")) {
		flgTuchiura.txtTuchiura_JK_K1 = true;
    } else {
		flgTuchiura.txtTuchiura_JK_K1 = false;

    }
	if (isNumber("txtTuchiura_JK_J2")) {
		flgTuchiura.txtTuchiura_JK_J2 = true;
    } else {
		flgTuchiura.txtTuchiura_JK_J2 = false;
    }
	
	if (isNumber("txtTuchiura_JK_K2")) {
		flgTuchiura.txtTuchiura_JK_K2 = true;
    } else {
		flgTuchiura.txtTuchiura_JK_K2 = false;
    }
           
    if (isNumber("txtTuchiura_JK_J3")) {
		flgTuchiura.txtTuchiura_JK_J3 = true;
    } else {
		flgTuchiura.txtTuchiura_JK_J3 = false;
    }
    
	if (isNumber("txtTuchiura_JK_K3")) {
		flgTuchiura.txtTuchiura_JK_K3 = true;
    } else {
		flgTuchiura.txtTuchiura_JK_K3 = false;
    }
	
	if (isNumber("txtTuchiura_SubTotal1")) {
		flgTuchiura.txtTuchiura_SubTotal1 = true;
    } else {
		flgTuchiura.txtTuchiura_SubTotal1 = false;
    }
	
	if (isNumber("txtTuchiura_Total1")) {
		flgTuchiura.txtTuchiura_Total1 = true;
    } else {
		flgTuchiura.txtTuchiura_Total1 = false;
    }
	
	if(flgTuchiura.txtTuchiura_Kamotu1 && flgTuchiura.txtTuchiura_Kamotu2 && flgTuchiura.txtTuchiura_Kamotu3 &&
		flgTuchiura.txtTuchiura_Kamotu4 && flgTuchiura.txtTuchiura_Bus1   && flgTuchiura.txtTuchiura_Bus2  &&
		flgTuchiura.txtTuchiura_JK_J1 && flgTuchiura.txtTuchiura_JK_K1 && flgTuchiura.txtTuchiura_JK_J2 &&
		flgTuchiura.txtTuchiura_JK_K2 && flgTuchiura.txtTuchiura_JK_J3 && flgTuchiura.txtTuchiura_JK_K3 &&
		flgTuchiura.txtTuchiura_SubTotal1  && flgTuchiura.txtTuchiura_Total1)
	{
		return true;
	
	}else{
		return false;
	}
	
}

//=============================
//check Tukuba
//=============================
var flgTukuba = 
{
	txtTukuba_Kamotu1:false,
	txtTukuba_Kamotu2:false,
	txtTukuba_Kamotu3:false,
	txtTukuba_Kamotu4:false,
	txtTukuba_Bus1:false,
	txtTukuba_Bus2:false,
	txtTukuba_JK_J1:false,
	txtTukuba_JK_K1:false,
	txtTukuba_JK_J2:false,
	txtTukuba_JK_K2:false,
	txtTukuba_JK_J3:false,
	txtTukuba_JK_K3:false,
	txtTukuba_SubTotal1:false,
	txtTukuba_Total1:false
};

function checkTukuba(){
	if (isNumber("txtTukuba_Kamotu1")) {
		flgTukuba.txtTukuba_Kamotu1 = true;
	}else{
		flgTukuba.txtTukuba_Kamotu1 = false;
	}
	if (isNumber("txtTukuba_Kamotu2")) {
		flgTukuba.txtTukuba_Kamotu2 = true;
    } else {
		flgTukuba.txtTukuba_Kamotu2 = false;
    }
    if (isNumber("txtTukuba_Kamotu3")) {
		flgTukuba.txtTukuba_Kamotu3 = true;
    } else {
		flgTukuba.txtTukuba_Kamotu3 = false;
    }
	if (isNumber("txtTukuba_Kamotu4")) {
		flgTukuba.txtTukuba_Kamotu4 = true;
    } else {
		flgTukuba.txtTukuba_Kamotu4 = false;
    }      
 	if (isNumber("txtTukuba_Bus1")) {
		flgTukuba.txtTukuba_Bus1 = true;
    } else {
		flgTukuba.txtTukuba_Bus1 = false;
    }
 	if (isNumber("txtTukuba_Bus2")) {
		flgTukuba.txtTukuba_Bus2 = true;
    } else {
		flgTukuba.txtTukuba_Bus2 = false;
    }
	if (isNumber("txtTukuba_JK_J1")) {
		flgTukuba.txtTukuba_JK_J1 = true;
    } else {
		flgTukuba.txtTukuba_JK_J1 = false;
    }
	
	if (isNumber("txtTukuba_JK_K1")) {
		flgTukuba.txtTukuba_JK_K1 = true;
    } else {
		flgTukuba.txtTukuba_JK_K1 = false;

    }
	if (isNumber("txtTukuba_JK_J2")) {
		flgTukuba.txtTukuba_JK_J2 = true;
    } else {
		flgTukuba.txtTukuba_JK_J2 = false;
    }
	
	if (isNumber("txtTukuba_JK_K2")) {
		flgTukuba.txtTukuba_JK_K2 = true;
    } else {
		flgTukuba.txtTukuba_JK_K2 = false;
    }
           
    if (isNumber("txtTukuba_JK_J3")) {
		flgTukuba.txtTukuba_JK_J3 = true;
    } else {
		flgTukuba.txtTukuba_JK_J3 = false;
    }
    
	if (isNumber("txtTukuba_JK_K3")) {
		flgTukuba.txtTukuba_JK_K3 = true;
    } else {
		flgTukuba.txtTukuba_JK_K3 = false;
    }
	
	if (isNumber("txtTukuba_SubTotal1")) {
		flgTukuba.txtTukuba_SubTotal1 = true;
    } else {
		flgTukuba.txtTukuba_SubTotal1 = false;
    }
	
	if (isNumber("txtTukuba_Total1")) {
		flgTukuba.txtTukuba_Total1 = true;
    } else {
		flgTukuba.txtTukuba_Total1 = false;
    }
	
	if(flgTukuba.txtTukuba_Kamotu1 && flgTukuba.txtTukuba_Kamotu2 && flgTukuba.txtTukuba_Kamotu3 &&
		flgTukuba.txtTukuba_Kamotu4 && flgTukuba.txtTukuba_Bus1   && flgTukuba.txtTukuba_Bus2  &&
		flgTukuba.txtTukuba_JK_J1 && flgTukuba.txtTukuba_JK_K1 && flgTukuba.txtTukuba_JK_J2 &&
		flgTukuba.txtTukuba_JK_K2 && flgTukuba.txtTukuba_JK_J3 && flgTukuba.txtTukuba_JK_K3 &&
		flgTukuba.txtTukuba_SubTotal1  && flgTukuba.txtTukuba_Total1)
	{
		return true;
	
	}else{
		return false;
	}
	
}


//=============================
//check Sonota
//=============================
var flgSonota = 
{
	txtSonota_Kamotu1:false,
	txtSonota_Kamotu2:false,
	txtSonota_Kamotu3:false,
	txtSonota_Kamotu4:false,
	txtSonota_Bus1:false,
	txtSonota_Bus2:false,
	txtSonota_JK_J1:false,
	txtSonota_JK_K1:false,
	txtSonota_JK_J2:false,
	txtSonota_JK_K2:false,
	txtSonota_JK_J3:false,
	txtSonota_JK_K3:false,
	txtSonota_SubTotal1:false,
	txtSonota_Total1:false
};

function checkSonota(){
	if (isNumber("txtSonota_Kamotu1")) {
		flgSonota.txtSonota_Kamotu1 = true;
	}else{
		flgSonota.txtSonota_Kamotu1 = false;
	}
	if (isNumber("txtSonota_Kamotu2")) {
		flgSonota.txtSonota_Kamotu2 = true;
    } else {
		flgSonota.txtSonota_Kamotu2 = false;
    }
    if (isNumber("txtSonota_Kamotu3")) {
		flgSonota.txtSonota_Kamotu3 = true;
    } else {
		flgSonota.txtSonota_Kamotu3 = false;
    }
	if (isNumber("txtSonota_Kamotu4")) {
		flgSonota.txtSonota_Kamotu4 = true;
    } else {
		flgSonota.txtSonota_Kamotu4 = false;
    }      
 	if (isNumber("txtSonota_Bus1")) {
		flgSonota.txtSonota_Bus1 = true;
    } else {
		flgSonota.txtSonota_Bus1 = false;
    }
 	if (isNumber("txtSonota_Bus2")) {
		flgSonota.txtSonota_Bus2 = true;
    } else {
		flgSonota.txtSonota_Bus2 = false;
    }
	if (isNumber("txtSonota_JK_J1")) {
		flgSonota.txtSonota_JK_J1 = true;
    } else {
		flgSonota.txtSonota_JK_J1 = false;
    }
	
	if (isNumber("txtSonota_JK_K1")) {
		flgSonota.txtSonota_JK_K1 = true;
    } else {
		flgSonota.txtSonota_JK_K1 = false;

    }
	if (isNumber("txtSonota_JK_J2")) {
		flgSonota.txtSonota_JK_J2 = true;
    } else {
		flgSonota.txtSonota_JK_J2 = false;
    }
	
	if (isNumber("txtSonota_JK_K2")) {
		flgSonota.txtSonota_JK_K2 = true;
    } else {
		flgSonota.txtSonota_JK_K2 = false;
    }
           
    if (isNumber("txtSonota_JK_J3")) {
		flgSonota.txtSonota_JK_J3 = true;
    } else {
		flgSonota.txtSonota_JK_J3 = false;
    }
    
	if (isNumber("txtSonota_JK_K3")) {
		flgSonota.txtSonota_JK_K3 = true;
    } else {
		flgSonota.txtSonota_JK_K3 = false;
    }
	
	if (isNumber("txtSonota_SubTotal1")) {
		flgSonota.txtSonota_SubTotal1 = true;
    } else {
		flgSonota.txtSonota_SubTotal1 = false;
    }
	
	if (isNumber("txtSonota_Total1")) {
		flgSonota.txtSonota_Total1 = true;
    } else {
		flgSonota.txtSonota_Total1 = false;
    }
	
	if(flgSonota.txtSonota_Kamotu1 && flgSonota.txtSonota_Kamotu2 && flgSonota.txtSonota_Kamotu3 &&
		flgSonota.txtSonota_Kamotu4 && flgSonota.txtSonota_Bus1   && flgSonota.txtSonota_Bus2  &&
		flgSonota.txtSonota_JK_J1 && flgSonota.txtSonota_JK_K1 && flgSonota.txtSonota_JK_J2 &&
		flgSonota.txtSonota_JK_K2 && flgSonota.txtSonota_JK_J3 && flgSonota.txtSonota_JK_K3 &&
		flgSonota.txtSonota_SubTotal1  && flgSonota.txtSonota_Total1)
	{
		return true;
	
	}else{
		return false;
	}
	
}

//=============================
//check Goukei
//=============================
var flgGoukei = 
{
	txtGoukei_Kamotu1:false,
	txtGoukei_Kamotu2:false,
	txtGoukei_Kamotu3:false,
	txtGoukei_Kamotu4:false,
	txtGoukei_Bus1:false,
	txtGoukei_Bus2:false,
	txtGoukei_JK_J1:false,
	txtGoukei_JK_K1:false,
	txtGoukei_JK_J2:false,
	txtGoukei_JK_K2:false,
	txtGoukei_JK_J3:false,
	txtGoukei_JK_K3:false,
	txtGoukei_SubTotal1:false,
	txtGoukei_Total1:false
};

function checkGoukei(){
	if (isNumber("txtGoukei_Kamotu1")) {
		flgGoukei.txtGoukei_Kamotu1 = true;
	}else{
		flgGoukei.txtGoukei_Kamotu1 = false;
	}
	if (isNumber("txtGoukei_Kamotu2")) {
		flgGoukei.txtGoukei_Kamotu2 = true;
    } else {
		flgGoukei.txtGoukei_Kamotu2 = false;
    }
    if (isNumber("txtGoukei_Kamotu3")) {
		flgGoukei.txtGoukei_Kamotu3 = true;
    } else {
		flgGoukei.txtGoukei_Kamotu3 = false;
    }
	if (isNumber("txtGoukei_Kamotu4")) {
		flgGoukei.txtGoukei_Kamotu4 = true;
    } else {
		flgGoukei.txtGoukei_Kamotu4 = false;
    }      
 	if (isNumber("txtGoukei_Bus1")) {
		flgGoukei.txtGoukei_Bus1 = true;
    } else {
		flgGoukei.txtGoukei_Bus1 = false;
    }
 	if (isNumber("txtGoukei_Bus2")) {
		flgGoukei.txtGoukei_Bus2 = true;
    } else {
		flgGoukei.txtGoukei_Bus2 = false;
    }
	if (isNumber("txtGoukei_JK_J1")) {
		flgGoukei.txtGoukei_JK_J1 = true;
    } else {
		flgGoukei.txtGoukei_JK_J1 = false;
    }
	
	if (isNumber("txtGoukei_JK_K1")) {
		flgGoukei.txtGoukei_JK_K1 = true;
    } else {
		flgGoukei.txtGoukei_JK_K1 = false;

    }
	if (isNumber("txtGoukei_JK_J2")) {
		flgGoukei.txtGoukei_JK_J2 = true;
    } else {
		flgGoukei.txtGoukei_JK_J2 = false;
    }
	
	if (isNumber("txtGoukei_JK_K2")) {
		flgGoukei.txtGoukei_JK_K2 = true;
    } else {
		flgGoukei.txtGoukei_JK_K2 = false;
    }
           
    if (isNumber("txtGoukei_JK_J3")) {
		flgGoukei.txtGoukei_JK_J3 = true;
    } else {
		flgGoukei.txtGoukei_JK_J3 = false;
    }
    
	if (isNumber("txtGoukei_JK_K3")) {
		flgGoukei.txtGoukei_JK_K3 = true;
    } else {
		flgGoukei.txtGoukei_JK_K3 = false;
    }
	
	if (isNumber("txtGoukei_SubTotal1")) {
		flgGoukei.txtGoukei_SubTotal1 = true;
    } else {
		flgGoukei.txtGoukei_SubTotal1 = false;
    }
	
	if (isNumber("txtGoukei_Total1")) {
		flgGoukei.txtGoukei_Total1 = true;
    } else {
		flgGoukei.txtGoukei_Total1 = false;
    }
	
	if(flgGoukei.txtGoukei_Kamotu1 && flgGoukei.txtGoukei_Kamotu2 && flgGoukei.txtGoukei_Kamotu3 &&
		flgGoukei.txtGoukei_Kamotu4 && flgGoukei.txtGoukei_Bus1   && flgGoukei.txtGoukei_Bus2  &&
		flgGoukei.txtGoukei_JK_J1 && flgGoukei.txtGoukei_JK_K1 && flgGoukei.txtGoukei_JK_J2 &&
		flgGoukei.txtGoukei_JK_K2 && flgGoukei.txtGoukei_JK_J3 && flgGoukei.txtGoukei_JK_K3 &&
		flgGoukei.txtGoukei_SubTotal1  && flgGoukei.txtGoukei_Total1)
	{
		return true;
	
	}else{
		return false;
	}
	
}


//空白はゼロに自動変換
function convertSpaceToZero(id) 
{
    if (!isEmpty(id)) {
        document.getElementById(id).value = "0";
    }
}

//水戸　ゼロ変換
function MitoZeroConverter() {
    convertSpaceToZero("txtMito_Kamotu1");
    convertSpaceToZero("txtMito_Kamotu2");
    convertSpaceToZero("txtMito_Kamotu3");
    convertSpaceToZero("txtMito_Kamotu4");
    convertSpaceToZero("txtMito_Bus1");
    convertSpaceToZero("txtMito_Bus2");
    convertSpaceToZero("txtMito_JK_J1");
    convertSpaceToZero("txtMito_JK_J2");
    convertSpaceToZero("txtMito_JK_J3");
    convertSpaceToZero("txtMito_JK_K1");
    convertSpaceToZero("txtMito_JK_K2");
    convertSpaceToZero("txtMito_JK_K3");
    convertSpaceToZero("txtMito_SubTotal1");
    convertSpaceToZero("txtMito_Total1");
}

//土浦　ゼロ変換
function TuchiuraZeroConverter() {
    convertSpaceToZero("txtTuchiura_Kamotu1");
    convertSpaceToZero("txtTuchiura_Kamotu2");
    convertSpaceToZero("txtTuchiura_Kamotu3");
    convertSpaceToZero("txtTuchiura_Kamotu4");
    convertSpaceToZero("txtTuchiura_Bus1");
    convertSpaceToZero("txtTuchiura_Bus2");
    convertSpaceToZero("txtTuchiura_JK_J1");
    convertSpaceToZero("txtTuchiura_JK_J2");
    convertSpaceToZero("txtTuchiura_JK_J3");
    convertSpaceToZero("txtTuchiura_JK_K1");
    convertSpaceToZero("txtTuchiura_JK_K2");
    convertSpaceToZero("txtTuchiura_JK_K3");
    convertSpaceToZero("txtTuchiura_SubTotal1");
    convertSpaceToZero("txtTuchiura_Total1");
}

//つくば　ゼロ変換
function TukubaZeroConverter() {
    convertSpaceToZero("txtTukuba_Kamotu1");
    convertSpaceToZero("txtTukuba_Kamotu2");
    convertSpaceToZero("txtTukuba_Kamotu3");
    convertSpaceToZero("txtTukuba_Kamotu4");
    convertSpaceToZero("txtTukuba_Bus1");
    convertSpaceToZero("txtTukuba_Bus2");
    convertSpaceToZero("txtTukuba_JK_J1");
    convertSpaceToZero("txtTukuba_JK_J2");
    convertSpaceToZero("txtTukuba_JK_J3");
    convertSpaceToZero("txtTukuba_JK_K1");
    convertSpaceToZero("txtTukuba_JK_K2");
    convertSpaceToZero("txtTukuba_JK_K3");
    convertSpaceToZero("txtTukuba_SubTotal1");
    convertSpaceToZero("txtTukuba_Total1");
}

//その他　ゼロ変換
function SonotaZeroConverter() {
    convertSpaceToZero("txtSonota_Kamotu1");
    convertSpaceToZero("txtSonota_Kamotu2");
    convertSpaceToZero("txtSonota_Kamotu3");
    convertSpaceToZero("txtSonota_Kamotu4");
    convertSpaceToZero("txtSonota_Bus1");
    convertSpaceToZero("txtSonota_Bus2");
    convertSpaceToZero("txtSonota_JK_J1");
    convertSpaceToZero("txtSonota_JK_J2");
    convertSpaceToZero("txtSonota_JK_J3");
    convertSpaceToZero("txtSonota_JK_K1");
    convertSpaceToZero("txtSonota_JK_K2");
    convertSpaceToZero("txtSonota_JK_K3");
    convertSpaceToZero("txtSonota_SubTotal1");
    convertSpaceToZero("txtSonota_Total1");
}

//合計　ゼロ変換
function GoukeiZeroConverter() {
    convertSpaceToZero("txtGoukei_Kamotu1");
    convertSpaceToZero("txtGoukei_Kamotu2");
    convertSpaceToZero("txtGoukei_Kamotu3");
    convertSpaceToZero("txtGoukei_Kamotu4");
    convertSpaceToZero("txtGoukei_Bus1");
    convertSpaceToZero("txtGoukei_Bus2");
    convertSpaceToZero("txtGoukei_JK_J1");
    convertSpaceToZero("txtGoukei_JK_J2");
    convertSpaceToZero("txtGoukei_JK_J3");
    convertSpaceToZero("txtGoukei_JK_K1");
    convertSpaceToZero("txtGoukei_JK_K2");
    convertSpaceToZero("txtGoukei_JK_K3");
    convertSpaceToZero("txtGoukei_SubTotal1");
    convertSpaceToZero("txtGoukei_Total1");
}

function checkForms() {

		//check Header
		if (checkFormsHeader() === false) {
			return false;
		}

        //ConvertSpaceTo0
        MitoZeroConverter();
        TuchiuraZeroConverter();
        TukubaZeroConverter();
        SonotaZeroConverter();
        GoukeiZeroConverter();

        //check Mito
		if (checkMito() === false) {
		    showMsg("lblMsg", "【水戸】の欄に数字以外の項目が含まれています");
		    return false;
		} else 
        {
            eraseMsg("lblMsg");
        }
		
		//check Tuchiura
        if (checkTuchiura() === false) {
            showMsg("lblMsg", "【土浦】の欄に数字以外の項目が含まれています");
			return false;
        } else {
            eraseMsg("lblMsg");
        }
		
		
		//check Tukuba
        if (checkTukuba() === false) {
            showMsg("lblMsg", "【つくば】の欄に数字以外の項目が含まれています");
			return false;
        } else {
            eraseMsg("lblMsg");
        }
		
		
		//check Sonota
        if (checkSonota() === false) {
            showMsg("lblMsg", "【その他】の欄に数字以外の項目が含まれています");
			return false;
        } else {
            eraseMsg("lblMsg");
        }
		
		
		//check Goukei
        if (checkGoukei() === false) {
            showMsg("lblMsg", "【合計】の欄に数字以外の項目が含まれています");
			return false;
        } else {
            eraseMsg("lblMsg");
        }
		

        if (!confirm("送信しますか？")) {
            //CSSがとれてしまう
            document.getElementById("txtMito_SubTotal1").style.backgroundColor = "Silver";
            document.getElementById("txtTuchiura_SubTotal1").style.backgroundColor = "Silver";
            document.getElementById("txtTukuba_SubTotal1").style.backgroundColor = "Silver";
            document.getElementById("txtSonota_SubTotal1").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_SubTotal1").style.backgroundColor = "Silver";

            document.getElementById("txtMito_Total1").style.backgroundColor = "Silver";
            document.getElementById("txtTuchiura_Total1").style.backgroundColor = "Silver";
            document.getElementById("txtTukuba_Total1").style.backgroundColor = "Silver";
            document.getElementById("txtSonota_Total1").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_Total1").style.backgroundColor = "Silver";

            document.getElementById("txtGoukei_Kamotu1").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_Kamotu2").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_Kamotu3").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_Kamotu4").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_Bus1").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_Bus2").style.backgroundColor = "Silver";

            document.getElementById("txtGoukei_JK_J1").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_JK_K1").style.backgroundColor = "Silver";

            document.getElementById("txtGoukei_JK_J2").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_JK_K2").style.backgroundColor = "Silver";

            document.getElementById("txtGoukei_JK_J3").style.backgroundColor = "Silver";
            document.getElementById("txtGoukei_JK_K3").style.backgroundColor = "Silver";

            return false;  
        
        }

}