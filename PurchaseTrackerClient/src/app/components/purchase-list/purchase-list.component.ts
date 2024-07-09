import { Component, OnInit } from '@angular/core';
import { Purchase, PurchaseService } from '../../services/purchase.service';

@Component({
  selector: 'app-purchase-list',
  templateUrl: './purchase-list.component.html',
  styleUrls: ['./purchase-list.component.scss']
})
export class PurchaseListComponent implements OnInit {
  public purchases: Purchase[] = [];
  public selectedPurchase: any;

  constructor(private purchaseService: PurchaseService) { }

  public ngOnInit(): void {
    this.purchaseService.getPurchases().subscribe(data => {
      this.purchases = data;
    });
  }

  public onSelect(purchase: Purchase): void {
    this.purchaseService.getPurchase(purchase.id).subscribe(data => {
      this.selectedPurchase = data;
    });
  }
}
