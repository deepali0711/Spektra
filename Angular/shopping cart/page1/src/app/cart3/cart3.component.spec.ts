import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Cart3Component } from './cart3.component';

describe('Cart3Component', () => {
  let component: Cart3Component;
  let fixture: ComponentFixture<Cart3Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Cart3Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Cart3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
