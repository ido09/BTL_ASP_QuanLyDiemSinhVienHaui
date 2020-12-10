<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="lib/bootstrap/bootstrap.min.css" />
    <link rel="stylesheet" href="css/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="wrapper-login">
          <div class="box-login">
               <div class="header">
                    <img src="images/logo-haui-size.png" width="70" alt="" />
                    <h4>Trường Đại Học Công Nghiệp Hà Nội</h4>
                    <h5>Đăng nhập</h5>
               </div>
               <div class="form-login">
                    <form action="/" method="get">
                         <div class="form-group">
                              <input type="text" placeholder="Tên đăng nhập" />
                         </div>
                         <div class="form-group">
                              <input type="password" placeholder="Mật khẩu" />
                         </div>
                         <div class="form-group">
                              <input type="button" value="Đăng Nhập" />
                         </div>
                    </form>
               </div>
               <div class="footer">
                    <p>Bạn quên mật khẩu? <a href="#">Quên mật khẩu</a></p>
                    <p>Hướng dẫn quên mật khẩu? <a href="#">Xem hướng dẫn</a></p>
               </div>
          </div>
     </div>
        </div>
    </form>
</body>
    <script src="lib/bootstrap/bootstrap.min.js"></script>
</html>
