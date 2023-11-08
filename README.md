# Booking
**השכרת צימרים -Booking.com**

תאור הפרויקט: מערכת לניהול השכרת צימרים


**ישויות**

צימרים

הזמנות

משכירים



מיפוי routes לצימרים
   - שליפת רשימת צימרים: 
GET [https://booking.co.il/Zimmer](https://booking.co.il/orders)  
 - שליפת צימר לפי מזהה: 
GET  [https://booking.co.il/Zimmer/{id}](https://booking.co.il/orders%7Bid%7D)  
 - הוספת צימר:
POST [https://booking.co.il/Zimmer](https://booking.co.il/orders)  
 - עדכון צימר:
PUT [https://booking.co.il/Zimmer/{id}](https://booking.co.il/orders%7Bid%7D)  
 - מחיקת צימר: 
 DELETE [https://booking.co.il/Zimmer/{id}](https://booking.co.il/orders%7Bid%7D)
 
מיפוי routes להזמנות
   - שליפת רשימת הזמנות: 
GET [https://booking.co.il/Orders](https://booking.co.il/orders)  
 - שליפת הזמנה לפי מזהה: 
GET  [https://booking.co.il/Orders/{id}](https://booking.co.il/orders%7Bid%7D)  
 - הוספת הזמנה:
POST [https://booking.co.il/Orders](https://booking.co.il/orders)  
 - עדכון הזמנה:
PUT [https://booking.co.il/Orders/{id}](https://booking.co.il/orders%7Bid%7D)  
 - מחיקת הזמנה: 
 DELETE [https://booking.co.il/Orders/{id}](https://booking.co.il/orders%7Bid%7D)

מיפוי routes למשכירים
   - שליפת רשימת משכירים: 
GET [https://booking.co.il/Renter](https://booking.co.il/orders)  
 - שליפת משכיר לפי מזהה: 
GET  [https://booking.co.il/Renter/{id}](https://booking.co.il/orders%7Bid%7D)  
 - הוספת משכיר:
POST [https://booking.co.il/Renter](https://booking.co.il/orders)  
 - עדכון משכיר:
PUT [https://booking.co.il/Renter/{id}](https://booking.co.il/orders%7Bid%7D)  
 - מחיקת משכיר: 
 DELETE [https://booking.co.il/Renter/{id}](https://booking.co.il/orders%7Bid%7D)
