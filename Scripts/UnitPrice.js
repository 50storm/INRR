var flag =
        {
            BigSize: false,
            MediumSmall: false,
            Average: false,
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
    return true;

}
