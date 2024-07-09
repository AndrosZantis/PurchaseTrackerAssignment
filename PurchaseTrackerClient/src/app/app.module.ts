import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';

import { AppComponent } from './app.component';
import { PurchaseListComponent } from './components/purchase-list/purchase-list.component';
import { PurchaseService } from './services/purchase.service';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';

@NgModule({
  declarations: [
    AppComponent,
    PurchaseListComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatTableModule,
    MatButtonModule
  ],
  providers: [PurchaseService, provideAnimationsAsync()],
  bootstrap: [AppComponent]
})
export class AppModule { }
