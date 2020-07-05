/*注册页面*/
$(function () {
    $('#sign').click(function () {
        var ac = $('#u_account').val();
        var name = $('#u_name').val();
        var ps = $('#u_password').val();
        var tel = $('#u_tel').val();
        var e = $('#u_email').val();

        var req1 = new RegExp(/^([a-zA-Z]|_)/);
        var req2 = new RegExp(/^(?![0-9]+$)(?![a-z]+$)(?![A-Z]+$)(?!([^(0-9a-zA-Z)])+$)^/);
        var req3 = new RegExp(/^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$/);

        if(req1.test(ac)){
            if(req2.test(ps)){
                if(ps.length>=8){
                    if(tel.length==11){
                        if(req3.test(e)){
                            alert("用户名："+ac+"用户姓名："+name+ "密码:"+ps+"出生日期：" +$("#u_date").val()+"电话："+$('#u_tel').val()+"email:"+$('#u_email').val());
                        }
                        else{
                            alert("邮箱格式错误");
                        }
                    }
                    else{
                        alert("输入11位手机号码");
                    }
                }
                else{
                    alert('密码强度不够！长度大于8位');
                }
            }
            else{
                alert('密码强度不够！需要包含大小写字母');
            }
        }
        else{
            alert('用户名错误！以下划线或字母开头');
        }
    });
});