/*进行在线的成绩测评*/
$(function () {
    //当点击提交按钮后，对用户提交答案进行检查，返回得分
    $('#btn_Score').click(function () {
        var score1,score2,score3,score4;
        if($('#id_sh').prop('checked')&&$('#id_bj').prop('checked')&&$('#id_tj').prop('checked')&&(!$('#id_sz').prop('checked'))){
            t1 = 1;
        }
        else{
            t1 = 0;
        }
        if($('#id_2').prop('checked')){
            t2 = 1;
        }
        else{
            t2 = 0;
        }
        
        if(t1 == 1){
            result = "第1题回答正确";
        }
        else{
            result = "第1题回答错误";
        }

        if(t2 == 1){
            result = result + "，第2题回答正确";
        }
        else{
            result = result + "，第2题回答错误";
        }

        result = result + "。";

        alert(result);

    });
})
