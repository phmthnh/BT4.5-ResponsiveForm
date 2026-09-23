# 📐 Bài Tập 4.5 – Responsive Form với TableLayoutPanel

Bài tập thiết kế giao diện quản lý danh sách chuẩn **responsive** — giao diện tự co giãn theo kích thước cửa sổ, không bị vỡ layout khi phóng to Maximize.

---

## 📋 Mô tả

Ứng dụng quản lý danh sách người dùng với bố cục hai cột linh hoạt:
- **Cột trái (30%)** — khu vực nhập liệu với GroupBox, các TextBox tự giãn theo chiều ngang
- **Cột phải (70%)** — DataGridView hiển thị danh sách, các nút bấm luôn nằm ở góc phải dưới

Kỹ thuật chính sử dụng:
- `TableLayoutPanel` với `Dock = Fill` và tỷ lệ cột `30% / 70%`
- `TextBox` đặt `Anchor = Top, Left, Right` → tự co giãn ngang
- Nút bấm đặt `Anchor = Bottom, Right` → luôn bám góc phải dưới

---

## 🖼️ Giao diện

### Giao diện mặc định
![Giao diện chính](Screenshot%202026-09-23%20165055.png)

### Thêm người dùng mới
![Thêm thành công](Screenshot%202026-09-23%20165205.png)

### Xóa dòng (có xác nhận)
![Xác nhận xóa](Screenshot%202026-09-23%20165240.png)

### Sau khi xóa dữ liệu
![Sau khi xóa](Screenshot%202026-09-23%20165309.png)

---

## ⚙️ Các thành phần chính

| Tên Control | Cấu hình | Chức năng |
|-------------|----------|-----------|
| `TableLayoutPanel` | `Dock = Fill` · 30% / 70% | Khung bố cục chính |
| `GroupBox` | Cột trái | Nhóm các ô nhập liệu |
| `txtName` `txtEmail` `txtPhone` | `Anchor = Top,Left,Right` | Tự co giãn theo cột |
| `DataGridView` | `Dock = Fill` | Hiển thị danh sách |
| `btnAdd` | `Anchor = Bottom,Right` | Thêm dòng mới |
| `btnDelete` | `Anchor = Bottom,Right` | Xóa dòng đang chọn |
| `btnClear` | `Anchor = Bottom,Right` | Xóa trắng form nhập |

---

## 🚀 Cách chạy

**Bằng Visual Studio:**
1. Mở file `BT4_5_ResponsiveForm.sln`
2. Nhấn `F5` để chạy

**Bằng terminal:**
```bash
dotnet run
```

---

## 🛠️ Yêu cầu
- .NET 10.0 SDK
- Windows OS
- Visual Studio 2022 trở lên
