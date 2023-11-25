"""
https://docs.djangoproject.com/en/4.2/topics/http/urls/
"""
from django.contrib import admin
from django.urls import path
from django.conf.urls.static import static
from django.conf import settings
from . import views

urlpatterns = [
    path('', views.myHome, name='home'),
    path('about/', views.myHome, name='about'),
    path('transformer/<int:id>/', views.viewone, name='viewone')
]

urlpatterns += static(settings.STATIC_URL, document_root=settings.STATIC_ROOT)
