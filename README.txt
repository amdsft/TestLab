# LabTest - مشروع تعليمي لاختبار البرمجيات

هذا المستودع عام ويهدف إلى التعلم والتدرب على كتابة الاختبارات (Unit Tests و Integration Tests) في مشروع ASP.NET Core Minimal API.

## المتطلبات

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Git
- محرر نصوص مثل Visual Studio Code أو Visual Studio 2022

## طريقة تثبيت المشروع

1. **استنساخ المستودع:**

   افتح الطرفية (Terminal) ونفّذ الأمر التالي:
   ```bash
   git clone https://github.com/username/LabTest.git
   cd LabTest
استعادة الحزم وبناء المشروع:

نفّذ الأمر التالي من جذر المستودع:

bash
Copy
dotnet restore
dotnet build
تشغيل المشروع
لتشغيل المشروع، استخدم الأمر التالي:

bash
Copy
dotnet run --project LabTest
بعد تشغيل التطبيق، ستظهر رسالة في الطرفية تحتوي على عنوان URL (مثلاً: https://localhost:5001). يمكنك فتح هذا العنوان في المتصفح لاستعراض الـ API.

تشغيل الاختبارات
المشروع يحتوي على قسمين للاختبارات:

LabTest.Unit.Tests: يحتوي على اختبارات الوحدة (Unit Tests) التي تختبر منطق العمل (Business Logic) بشكل منفصل.
LabTest.IntegrationTests: يحتوي على اختبارات التكامل (Integration Tests) التي تختبر نقاط النهاية (Endpoints) باستخدام خادم اختبار في الذاكرة.
لتشغيل جميع الاختبارات، نفّذ الأمر التالي من جذر المستودع:

bash
Copy
dotnet test
سيقوم هذا الأمر ببناء المشاريع وتشغيل جميع الاختبارات وعرض النتائج في الطرفية.

بنية المشروع
LabTest/: يحتوي على كود الـ API الأساسي.
LabTest.Unit.Tests/: يحتوي على اختبارات الوحدة.
LabTest.IntegrationTests/: يحتوي على اختبارات التكامل.
المساهمة
إذا كان لديك أفكار أو تحسينات ترغب في إضافتها:

افتح Issue لمناقشة الفكرة.
يمكنك إرسال Pull Request لتقديم التعديلات.
الترخيص
هذا المشروع مرخص بموجب MIT License.

ملحوظة:
هذا المشروع لأغراض تعليمية فقط.

order this to make it nice for github readme
