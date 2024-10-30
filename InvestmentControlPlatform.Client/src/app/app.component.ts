import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Observable } from 'rxjs';
import { Asset } from '../models/asset.model';
import { AsyncPipe, CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HttpClientModule, AsyncPipe, CommonModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  http = inject(HttpClient);
  assets$ = this.getAssets();

  private getAssets(): Observable<Asset[]> {
    const assets = this.http.get<Asset[]>('https://localhost:7199/api/Assets');
    
    assets.subscribe(data => {
      console.log('Received assets:', data);
    });
    
    return assets;
  }
  trackByAssetId(index: number, item: Asset): number {
    return item.assetId;
  }
}
