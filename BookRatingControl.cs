using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;

public partial class BookRatingControl : UserControl
{
	private List<PictureBox> ratingStars = new List<PictureBox>();
	private int currentRating = 0;

	public partial class BookRatingControl : UserControl
	{
		private List<PictureBox> ratingStars = new List<PictureBox>();
		private int currentRating = 0;

		public BookRatingControl()
		{
			InitializeComponent();
			InitializeRatingStars();
		}

		private void InitializeRatingStars()
		{
			for (int i = 2; i <= 11; i++)
			{
				PictureBox pictureBox = Controls.Find("pictureBox" + i, true)[0] as PictureBox;
				if (pictureBox != null)
				{
					pictureBox.Tag = i - 1;
					pictureBox.Click += StarPictureBox_Click;
					ratingStars.Add(pictureBox);
				}
			}
		}

		private void StarPictureBox_Click(object sender, EventArgs e)
		{
			PictureBox clickedStar = sender as PictureBox;
			int clickedRating = (int)clickedStar.Tag;

			currentRating = clickedRating;

			for (int i = 0; i < ratingStars.Count; i++)
			{
				if (i < clickedRating)
				{
					ratingStars[i].Image = WindowsFormsAppLibraryProject.Properties.Resources.filled_star;
				}
				else
				{
					ratingStars[i].Image = WindowsFormsAppLibraryProject.Properties.Resources.empty_star;
				}
			}

			// Event to notify the application of the new rating
			OnRatingChanged(new RatingChangedEventArgs(currentRating));
		}

		public event EventHandler<RatingChangedEventArgs> RatingChanged;

		protected virtual void OnRatingChanged(RatingChangedEventArgs e)
		{
			RatingChanged?.Invoke(this, e);
		}
	}

	private void pictureBox_Click(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	private void StarPictureBox_Click(object sender, EventArgs e)
	{
		PictureBox clickedStar = sender as PictureBox;
		int clickedRating = (int)clickedStar.Tag;

		currentRating = clickedRating;

		for (int i = 0; i < ratingStars.Count; i++)
		{
			if (i < clickedRating)
			{
				ratingStars[i].Image = WindowsFormsAppLibraryProject.Properties.Resources.filled_star;
			}
			else
			{
				ratingStars[i].Image = WindowsFormsAppLibraryProject.Properties.Resources.empty_star;
			}
		}

		// Event to notify the application of the new rating
		OnRatingChanged(new RatingChangedEventArgs(currentRating));
	}

	public event EventHandler<RatingChangedEventArgs> RatingChanged;

	protected virtual void OnRatingChanged(RatingChangedEventArgs e)
	{
		RatingChanged?.Invoke(this, e);
	}
}
