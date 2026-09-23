# BT4.5 – Thiết kế Responsive Form với TableLayoutPanel và Anchor/Dock

> **Môn:** Lập trình Windows Forms với C# | **Framework:** .NET 10.0

## Mục tiêu
Thiết kế Form quản lý **chuẩn responsive** — không vỡ giao diện khi phóng to Maximize cửa sổ.

## Tính năng & Layout

| Thành phần | Cấu hình |
|------------|----------|
| `TableLayoutPanel` | `Dock = Fill` · 2 cột: **30%** và **70%** |
| Cột trái (30%) | `GroupBox` chứa các `TextBox` nhập liệu · Anchor = `Top, Left, Right` |
| Cột phải (70%) | `DataGridView` hiển thị danh sách · tự co giãn |
| Nút bấm | Anchor = `Bottom, Right` — luôn ở góc phải dưới khi resize |
| `btnAdd` | Thêm dòng mới vào `DataGridView` |
| `btnDelete` | Xóa dòng đang chọn (có xác nhận) |
| `btnClear` | Xóa trắng form nhập liệu |

## Demo

### Giao diện mặc định
![Responsive Form - Giao diện](Screenshot%202026-09-23%20165055.png)

### Thêm dữ liệu mới
![Responsive Form - Thêm thành công](Screenshot%202026-09-23%20165205.png)

### Xóa dòng (có xác nhận)
![Responsive Form - Xác nhận xóa](Screenshot%202026-09-23%20165240.png)

### Sau khi xóa
![Responsive Form - Sau khi xóa](Screenshot%202026-09-23%20165309.png)

## Cách chạy

```bash
dotnet run
```

hoặc mở file `BT4_5_ResponsiveForm.sln` bằng **Visual Studio 2022+** và nhấn `F5`.

## Yêu cầu hệ thống
- .NET 10.0 SDK
- Windows OS (Windows Forms)
- Visual Studio 2022 (khuyến nghị)
