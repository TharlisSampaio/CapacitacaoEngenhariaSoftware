# Generated by Django 4.2.2 on 2023-06-23 04:19

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('agenda', '0009_rename_user_id_convidado_user'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='convidado',
            name='user',
        ),
    ]