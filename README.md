# csn-da21tta-nguyenthicamtien-quanlydiemgiangvien-csharp
# I. Mục tiêu
- Xây dựng hệ thống quản lý điểm của giảng viên nhằm giúp giảng viên thực hiện các công việc sau một cách dễ dàng và hiệu quả:
  #### 1. Quản lý công việc vào điểm quá trình và điểm thi (lần 1 và lần 2).
  #### 2. Quản lý thời gian (ra đề thi, chấm bài thi).
  #### 3. Quản lý môn học (đã/chưa được tổ chức thi).
  #### 4. Báo cáo thống kê
# II. Yêu cầu
- Hệ thống phải đáp ứng các yêu cầu sau:
  ##### 1. Dễ sử dụng, thân thiện với người dùng.
  ##### 2. An toàn, bảo mật thông tin.
  ##### 3. Hỗ trợ quản lý điểm cho nhiều môn học, nhiều lớp học.
  ##### 4. Hỗ trợ báo cáo thống kê đa dạng.
# III. Công nghệ sử 
- .net framework 4.8 winform application
- Entityframework
- SQL Server
# IV. Mô tả cơ sở dữ liệu
#### 1. Bảng tài khoản: quản lý tài khoản đăng nhập hệ thống.
#### 2. Bảng quyền: phân quyền hệ thống.
#### 3. Bảng quyền tài khoản: tài khoản sẽ có quyền nào trong hệ thống.
#### 4. Bảng khóa học: quản lý khóa học.
#### 5. Bảng nghành: quản lý nghành học.
#### 6. Bảng nghành và khóa học: liên kết giữa nghành và khóa học.
#### 7. Bảng học kỳ: quản lý học kỳ.
#### 8. Bảng học kỳ khóa học: liên kết giữa học kỳ và khóa học.
#### 9. Bảng lớp: quản lý lớp học.
#### 10. Bảng môn học: quản lý môn học.
#### 11. Bảng sinh viên: quản lý sinh viên.
#### 12. Bảng thời gian thi: quản lý thời gian thi của môn học.
#### 13. Bảng chấm thi: quản lý thời gian chấm thi của môn học.
# V. Mô tả chức năng
## 1. Chức năng đăng nhập: 
+ Nhập tên tài khoản và mật khẩu.
+ Đúng thì sẽ đăng nhập vào hệ thống ngược lại sai sẽ thông báo và yêu cầu nhập lại.
## 2. Chức năng in ra danh sách tài khoản:
+ Sau khi đăng nhập vào tài khoản có quyền cao nhất, người dùng sẽ chọn đến “Danh sách tài khoản”.
+ Sau khi chọn xong sẽ in ra danh sách các tài khoản giảng viên có trong hệ thống.
+ Người dùng có thể tìm kiếm và phân quyền cho tài khoản.
## 3. Chức năng phân quyền tài khoản:
+ Tại giao diện “Danh sách tài khoản” người dùng chọn một tài khoản giảng viên muốn phân quyền.
+ Sau khi chọn sẽ nhấn vào phân quyền tài khoản, sẽ hiện ra một form để người dùng phân quyền cho tài khoản.
+ Phân quyền xong nhấn lưu và cập nhập vào db.
## 4. Chức năng thêm mới tài khoản:
+ Tại giao diện “Danh sách tài khoản” người dùng nhấn nút “Thêm mới tài khoản”.
+ Sau khi nhấn nút “Thêm mới tài khoản” sẽ hiện ra một form thêm mới tài khoản.
+ Người dùng nhập đầy đủ thông tin và nhấn lưu.
## 5. Chức năng sửa tài khoản:
+ Tại giao diện “Danh sách tài khoản” người dùng nhấn nút “Sửa tài khoản”
+ Sau khi nhấn nút “Sửa tài khoản” sẽ hiện ra một form sửa tài khoản.
+ Người dùng nhập đầy đủ thông tin và nhấn lưu.
## 6. Chức năng xóa tài khoản:
+ Tại giao diện “Danh sách tài khoản” người dùng chọn một tài khoản muốn xóa
+ Sau khi nhấn nút “Xóa tài khoản” sẽ hiện ra một form xác nhận xóa.
+ Người dùng nhấn “OK” để xóa hoặc “Cancel” để hủy.
## 7. Chức năng in danh sách môn học:
+ Sau khi đăng nhập vào tài khoản có quyền cao nhất, người dùng sẽ chọn đến “Danh sách môn học”
+ Sau khi chọn xong sẽ in ra danh sách các môn học có trong hệ thống.
+ Người dùng có thể tìm kiếm và xem được thời gian thi, chấm bài thi của môn học đó. Nếu môn học đó chưa thi có thể ra quản lý thời gian ra đề thi và chấm bài thi.
## 8. Chức năng quản lý thời gian ra đề thi:
+ Tại giao diện “Danh sách môn học” người dùng chọn một môn học chưa được ra đề thi
+ Sau khi chọn sẽ nhấn vào “Quản lý thời gian ra đề thi”, sẽ hiện ra một form để người dùng cập nhập thời gian thi cho môn học đó.
+ Xong nhấn lưu và cập nhập vào db.
## 9. Chức năng thêm mới môn học:
+ Tại giao diện “Danh sách môn học” người dùng nhấn nút “Thêm mới môn học”
+ Sau khi nhấn nút “Thêm mới môn học” sẽ hiện ra một form thêm mới môn học.
+ Người dùng nhập đầy đủ thông tin và nhấn lưu.
## 10. Chức năng sửa môn học:
+ Tại giao diện “Danh sách môn học” người dùng nhấn nút “Sửa môn học”
+ Sau khi nhấn nút “Sửa môn học” sẽ hiện ra một form sửa môn học.
+ Người dùng nhập đầy đủ thông tin và nhấn lưu.
## 11. Chức năng xóa môn học:
+ Tại giao diện “Danh sách môn học” người dùng chọn một môn học muốn xóa.
+ Sau khi nhấn nút “Xóa môn học” sẽ hiện ra một form xác nhận xóa.
+ Người dùng nhấn “OK” để xóa hoặc “Cancel” để hủy.
## 12. Chức năng in danh sách sinh viên:
+ Sau khi đăng nhập vào tài khoản có quyền cao nhất, người dùng sẽ chọn đến “Danh sách sinh viên”.
+ Sau khi chọn xong sẽ in ra danh sách các sinh viên có trong hệ thống.
+ Người dùng có thể tìm kiếm và xem được thông tin và các môn học đã thi và điểm.
## 13. Chức năng quản lý điểm môn học của sinh viên:
+ Tại giao diện “Danh sách sinh viên” người dùng chọn một sinh viên cần xem điểm của các môn học.
+ Sau khi chọn sẽ nhấn vào “Xem điểm của sinh viên”, sẽ hiện ra một danh sách điểm của các môn học của sinh viên.
+ Người dùng có thể xem, sửa, xóa điểm của môn học đó.
## 14. Chức năng thêm điểm môn học cho sinh viên:
+ Tại giao diện “Danh sách môn học của sinh viên” người dùng nhấn nút “Thêm điểm của sinh viên” chưa có điểm
+ Sau khi nhấn nút “Thêm điểm của sinh viên” sẽ hiện ra một form thêm mới điểm của môn học đó.
+ Người dùng nhập đầy đủ thông tin và nhấn lưu.
## 15. Chức năng sửa điểm môn học cho sinh viên:
+ Tại giao diện “Danh sách môn học của sinh viên” người dùng nhấn nút “Sửa môn học của sinh viên”
+ Sau khi nhấn nút “Sửa môn học của sinh viên” sẽ hiện ra một form sửa môn học.
+ Người dùng nhập đầy đủ thông tin và nhấn lưu.
## 16. Chức năng xóa điểm môn học của sinh viên:
+ Tại giao diện “Danh sách môn học của sinh viên” người dùng chọn một môn học muốn xóa.
+ Sau khi nhấn nút “Xóa điểm môn học của sinh viên” sẽ hiện ra một form xác nhận xóa.
+ Người dùng nhấn “OK” để xóa hoặc “Cancel” để hủy.
## 17. Chức năng báo cáo:
+ Tại các giao diện danh sách nhấn nút “Xuất báo cáo”
+ Sau khi nhấn nút “Xuất báo cáo” sẽ xuất ra file excel.






  
  
