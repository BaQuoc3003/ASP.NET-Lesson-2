# Lesson 2 - ASP.NET Core MVC

Bài thực hành buổi 2, bổ sung ví dụ Conventional Routing, Attribute Routing,
View Component và Partial View.

## Chạy dự án

1. Mở `Lesson_2.slnx` bằng Visual Studio hoặc mở thư mục dự án.
2. Đảm bảo đã cài .NET SDK phù hợp với `net10.0` trong `Lesson_2/Lesson_2.csproj`.
3. Mở Terminal tại thư mục chứa `Lesson_2.csproj`, chạy:

   ```bash
   dotnet restore
   dotnet run
   ```

4. Mở URL localhost được in ra trong Terminal.

## Ví dụ 1 - Conventional Routing và Attribute Routing

- Conventional Routing: `/RoutingDemo/Product/5`
  - Được ánh xạ theo mẫu mặc định trong `Program.cs`:
    `{controller=Home}/{action=Index}/{id?}`
  - `RoutingDemo` là controller, `Product` là action, `5` là `id`.

- Attribute Routing: `/route-attribute/product/5`
  - Đường dẫn được khai báo trực tiếp bằng `[Route("route-attribute/product/{id:int}")]`
    trên action `ProductByAttribute` trong `Controllers/RoutingDemoController.cs`.
  - `:int` yêu cầu `id` là số nguyên.

## Ví dụ 2 - View Component và Partial View

Mở `/ViewDemo/Index`.

- View Component: `ViewComponents/WelcomeViewComponent.cs` xử lý dữ liệu và
  trả về giao diện ở `Views/Shared/Components/Welcome/Default.cshtml`.
  Trang gọi bằng `@await Component.InvokeAsync("Welcome", new { name = "Quốc" })`.
- Partial View: `Views/Shared/_StudentCard.cshtml` là một phần giao diện tái sử dụng.
  `Views/ViewDemo/Index.cshtml` truyền đối tượng `StudentViewModel` vào partial.

## Cấu trúc chính

- `Controllers/`: xử lý yêu cầu HTTP.
- `Models/`: lớp dữ liệu.
- `Views/`: giao diện Razor.
- `ViewComponents/`: logic và giao diện của View Component.
- `Program.cs`: cấu hình dịch vụ MVC và Conventional Routing.

## Ghi chú

Đây là bài tập học tập ASP.NET Core MVC. Không đưa thư mục `.vs`, `bin`, `obj` lên GitHub.
